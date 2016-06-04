using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using view = Client.Models;
using soaM = Client.MovieService;
using Client.Services;


namespace Client.ProcessObjects
{
    public class ProcessObject
    {
        public IMapper Mapper { get; set; }

        private readonly MovieSOAClient _movieClient;
        public MovieSOAClient MovieClient { get { return _movieClient; } }

        public ProcessObject()
        {
            CreateMapping();
           _movieClient = new MovieSOAClient(this);
        }

        private void CreateMapping()
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<view.Genre, soaM.Genre>().ForMember(dest => dest.GenreID, opt => opt.MapFrom(source => source.Id));
            cfg.CreateMap<soaM.Genre, view.Genre>().ForMember(dest => dest.Id, opt => opt.MapFrom(source => source.GenreID));
            cfg.CreateMap<soaM.Movie, view.Movie>().ForMember(dest => dest.Id, opt => opt.MapFrom(source => source.MovieID));
            cfg.CreateMap<view.Movie, soaM.Movie>().ForMember(dest => dest.MovieID, opt => opt.MapFrom(source => source.Id));//.ForMember(dest => dest.Genre, opt => opt.MapFrom(source => Mapper.Map<soaM.Genre, view.Genre>(source)));
            });

            Mapper = config.CreateMapper();
        }
    }
}
