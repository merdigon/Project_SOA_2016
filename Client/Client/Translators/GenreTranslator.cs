using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using view = Client.Models;
using soa = Client.MovieService;

namespace Client.Translators
{
    //public class GenreTranslator : ITranslator<view.Genre, soa.Genre>
    //{
    //    public static soa.Genre Pack(view.Genre obj)
    //    {
    //        if (obj == null)
    //            return null;

    //        return new soa.Genre()
    //        {
    //            GenreID = obj.Id,
    //            Name = obj.Name
    //        };
    //    }

    //    public static view.Genre Unpack(soa.Genre obj)
    //    {
    //        if (obj == null)
    //            return null;

    //        return new view.Genre()
    //        {
    //            Id = obj.GenreID,
    //            Name = obj.Name
    //        };
    //    }
    //}
}
