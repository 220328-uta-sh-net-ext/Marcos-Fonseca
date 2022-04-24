using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewDL
{
    public interface IRepo
    {
        List<Restaurant> GetAllRestaurants();

        void AddRestaurant(Restaurant restaurantToAdd);

        void AddReview(int restaurantId, Review reviewToAdd);

        List<Restaurant> SearchRestaurants(string searchTerm);

        bool IsDuplicate(Restaurant restaurant);
    }
}
