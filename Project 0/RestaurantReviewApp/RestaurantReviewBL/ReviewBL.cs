using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviewDL;
using RestaurantReviewModels;

namespace RestaurantReviewBL
{
    public class ReviewBL : Ireview
    {
        private readonly IRepo _dl;

        public ReviewBL(IRepo repo)
        {
            _dl = repo;
        }
        public void AddReview(Review reviewToAdd)
        {
            if (reviewToAdd.score > 5)
            {
                throw new InvalidOperationException("Score only goes between 1-5");
            }
            else
            {
                _dl.AddReview(reviewToAdd);
            }

        }

        public List<Review> RestaurantReviews(string name)
        {
            Restaurant restaurant = _dl.GetRestaurant(name);

            return _dl.GetReviewRestaurant(restaurant);
        }


    }
}

