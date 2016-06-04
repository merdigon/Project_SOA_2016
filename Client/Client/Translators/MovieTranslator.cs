using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using view = Client.Models;
using soa = Client.MovieService;

namespace Client.Translators
{
    //public class MovieTranslator : ITranslator<view.Movie, soa.Movie>
    //{
    //    public static soa.Movie Pack(view.Movie obj)
    //    {
    //        if (obj == null)
    //            return null;

    //        return new soa.Movie()
    //        {
    //            CoverURI = obj.CoverURI,
    //            Description = obj.Description,
    //            Genre = GenreTranslator.Pack(obj.Genre),
    //            MovieID = obj.Id,
    //            Title = obj.Title,
    //            Year = obj.Year
    //        };
    //    }

    //    public static view.Movie Unpack(soa.Movie obj)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
