using soaM = Client.MovieService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using view = Client.Models;
using Client.ProcessObjects;

namespace Client.Services
{
    public class MovieSOAClient
    {
        private soaM.MovieServiceClient Client { get; set; }
        public ProcessObject ProcessObject { get; set; }

        public MovieSOAClient(ProcessObject processObject)
        {
            Client = new soaM.MovieServiceClient();
            ProcessObject = processObject;
        }

        public List<view.Genre> GetAllGenres()
        {
            var list = (Client.GetGenres() ?? new soaM.Genre[0]);
            return list.Select(p => ProcessObject.Mapper.Map<view.Genre>(p)).ToList();
        }

        public view.Genre GetGenre(int id)
        {
            return GetAllGenres().Where(p => p.Id == id).SingleOrDefault();
        }

        public List<view.Movie> GetMoviesByTitlePart(string namePart)
        {
            var list = (Client.GetMoviesByTitlePart(namePart) ?? new soaM.Movie[0]);
            return list.Select(p => ProcessObject.Mapper.Map<view.Movie>(p)).ToList();
        }

        public List<view.Movie> GetMoviesByTitle(string name)
        {
            var list = (Client.GetMoviesByTitle(name) ?? new soaM.Movie[0]);
            return list.Select(p => ProcessObject.Mapper.Map<view.Movie>(p)).ToList();
        }

        public void DeleteMovie(int id)
        {
            Client.DeleteMovie(new soaM.Movie() { MovieID = id });
        }

        public bool UpdateMovie(view.Movie movie){
            soaM.Movie movieToUpdate = ProcessObject.Mapper.Map<soaM.Movie>(movie);
            return Client.UpdateMovie(movieToUpdate);
        }

        public view.Movie AddMovie(view.Movie movie)
        {
            soaM.Movie movieToUpdate = ProcessObject.Mapper.Map<soaM.Movie>(movie);
            return ProcessObject.Mapper.Map<view.Movie>(Client.AddMovie(movieToUpdate));
        }
    }
}
