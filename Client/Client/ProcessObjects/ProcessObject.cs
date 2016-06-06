using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using view = Client.Models;
using soaM = Client.MovieService;
using soaR = Client.ReviewServices.Library;
using soaU = Client.UserServices.Library;
using soaP = Client.PeopleService;
using Client.Services;


namespace Client.ProcessObjects
{
    public class ProcessObject
    {
        public IMapper Mapper { get; set; }
        public view.User LoggedUser { get; set; }

        private readonly MovieSOAClient _movieClient;
        private readonly ReviewSOAClient _reviewClient;
        private readonly PeopleSOAClient _peopleClient;
        private readonly UserSOAClient _userClient;
        public MovieSOAClient MovieClient { get { return _movieClient; } }
        public ReviewSOAClient ReviewClient { get { return _reviewClient; } }
        public PeopleSOAClient PeopleClient { get { return _peopleClient; } }
        public UserSOAClient UserClient { get { return _userClient; } }
        
        public ProcessObject()
        {
            CreateMapping();
            _movieClient = new MovieSOAClient(this);
            _reviewClient = new ReviewSOAClient(this);
            _peopleClient = new PeopleSOAClient(this);
            _userClient = new UserSOAClient(this);
        }

        private void CreateMapping()
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<view.Genre, soaM.Genre>().ForMember(dest => dest.GenreID, opt => opt.MapFrom(source => source.Id));
            cfg.CreateMap<soaM.Genre, view.Genre>().ForMember(dest => dest.Id, opt => opt.MapFrom(source => source.GenreID));
            cfg.CreateMap<soaM.Movie, view.Movie>().ForMember(dest => dest.Id, opt => opt.MapFrom(source => source.MovieID));
            cfg.CreateMap<view.Movie, soaM.Movie>().ForMember(dest => dest.MovieID, opt => opt.MapFrom(source => source.Id));//.ForMember(dest => dest.Genre, opt => opt.MapFrom(source => Mapper.Map<soaM.Genre, view.Genre>(source)));
            cfg.CreateMap<view.Review, soaR.Review>().ForMember(dest => dest.ReviewID, opt => opt.MapFrom(source => source.Id));
            cfg.CreateMap<soaR.Review, view.Review>().ForMember(dest => dest.Id, opt => opt.MapFrom(source => source.ReviewID));
            cfg.CreateMap<soaP.Actor, view.Actor>().ForMember(dest => dest.Id, opt => opt.MapFrom(source => source.PersonId));
            cfg.CreateMap<view.Actor, soaP.Actor>().ForMember(dest => dest.PersonId, opt => opt.MapFrom(source => source.Id));
            cfg.CreateMap<soaP.Director, view.Director>().ForMember(dest => dest.Id, opt => opt.MapFrom(source => source.PersonId));
            cfg.CreateMap<view.Director, soaP.Director>().ForMember(dest => dest.PersonId, opt => opt.MapFrom(source => source.Id));
            cfg.CreateMap<soaU.User, view.User>().ForMember(dest => dest.Id, opt => opt.MapFrom(source => source.UserId));
            cfg.CreateMap<view.User, soaU.User>().ForMember(dest => dest.UserId, opt => opt.MapFrom(source => source.Id));
            });

            Mapper = config.CreateMapper();
        }
    }
}
