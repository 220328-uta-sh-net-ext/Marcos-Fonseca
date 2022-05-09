using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviewModels;

namespace RestaurantReviewBL
{
    internal interface Ireview
    {
        void AddReview(Review reviewToAdd);
        List<Review> RestaurantReviews(string name);
    }
}
