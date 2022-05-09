using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviewModels;

namespace RestaurantReviewBL
{
    internal interface IBL
    {
        List<Restaurant> GetAllRestaurants();

        void AddRestaurant(Restaurant restaurantToAdd);
        Restaurant GetRestaurant(string name);
        List<Restaurant> SearchRestaurants(string searchTerm);
        List<Restaurant> AVGRestaurants();
        List<Restaurant> GetRestaurantByCity(string city);
        List<Restaurant> GetRestaurantByRating(string rating);

    }
}
