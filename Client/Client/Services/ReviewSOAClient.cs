using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Services.Default;
using soaR = Client.Services.Library;
using view = Client.Models;
using Client.ProcessObjects;

namespace Client.Services
{
    public class ReviewSOAClient
    {
        private readonly Container container;

        public ProcessObject ProcessObject { get; set; }

        public ReviewSOAClient(ProcessObject processObject)
        {
            string serviceUri = "http://localhost:49847/";
            container = new Container(new Uri(serviceUri));
            ProcessObject = processObject;
        }

        public List<view.Review> GetReviewsForMovie(int movieId)
        {
            var soaReviewList = container.Reviews.Where(p => p.MovieID == movieId).ToList();
            var viewList = soaReviewList.Select(p => ProcessObject.Mapper.Map<view.Review>(p)).ToList();
            return viewList;
        }

        public view.Review AddReview(view.Review review)
        {
            container.AddToReviews(ProcessObject.Mapper.Map<soaR.Review>(review));
            var operationStatus = container.SaveChanges();
            //foreach (var stat in operationStatus)
            //{
            //    stat.
            //}

            return review;
        }
    }
}
