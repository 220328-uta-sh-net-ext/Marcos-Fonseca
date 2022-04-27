using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewBL
{
    internal interface IBL
    {
        List<Restaurant> SearchRestaurants(string searchString);

        List<Restaurant> GetAllRestaurants();

        void AddRestaurant(Restaurant restaurantToAdd);

        void AddReview(int restaurantId, Review reviewToAdd);

        
    }
}
