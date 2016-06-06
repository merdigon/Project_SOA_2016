using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MoviesService.Models;
using MoviesService.DAL;

namespace MoviesService
{
    public class MovieService : IMovieService
    {
        private MovieContext db = new MovieContext();
        public List<Genre> GetGenres()
        {
            return db.Genres.ToList();
        }

        public List<Movie> GetMovies()
        {
            return db.Movies.Include("Genre").ToList();
        }

        public List<Movie> GetMoviesByGenre(Genre genre)
        {
            return db.Movies.Include("Genre").Where(x => x.Genre == genre).ToList();
        }

        public List<Movie> GetMoviesByTitle(string title)
        {
            return db.Movies.Include("Genre").Where(x => x.Title == title).ToList();
        }

        public List<Movie> GetMoviesByTitlePart(string part)
        {
            return db.Movies.Include("Genre").Where(x => x.Title.Contains(part)).ToList();
        }

        public List<Movie> GetMoviesByYear(int year)
        {
            return db.Movies.Include("Genre").Where(x => x.Year == year).ToList();
        }

        public List<Movie> GetMoviesByDirector(int id)
        {
            return db.Movies.Include("Genre").Where(x => x.DirectorID == id).ToList();
        }

        public List<Movie> GetMoviesByActor(int id)
        {
            return db.Movies.Include("Genre").Where(x => x.ActorIDs.Contains(id)).ToList();
        }


        public Movie AddMovie(Movie movie)
        {
            try 
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return movie;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Genre AddGenre(Genre genre)
        {
            try
            {
                db.Genres.Add(genre);
                db.SaveChanges();
                return genre;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void DeleteMovie(Movie movie)
        {
            db.Movies.Remove(movie);
            db.SaveChanges();
        }

        public void DeleteGenre(Genre genre)
        {
            db.Genres.Remove(genre);
            db.SaveChanges();
        }

        public bool UpdateMovie(Movie movie)
        {
            var result = db.Movies.SingleOrDefault(b => b.MovieID == movie.MovieID);
            if (result != null)
            {
                result.Description = movie.Description;
                result.CoverURI = movie.CoverURI;
                result.Genre = movie.Genre;
                result.Title = movie.Title;
                result.Country = movie.Country;
		result.DirectorID = movie.DirectorID;
		result.Actors = movie.Actors;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdateGenre(Genre genre)
        {

            var result = db.Genres.SingleOrDefault(b => b.GenreID == genre.GenreID);
            if (result != null)
            {
                result.Name = genre.Name;
                db.SaveChanges();
                return true;
            }
            return false;

        }
    }
}
