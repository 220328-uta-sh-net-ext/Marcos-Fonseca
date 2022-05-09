using RestaurantReviewModels;
using System.Data.SqlClient;
using RestaurantReviewDL;

namespace RestaurantReviewBL
{

    public class RRBL : IBL
    {
        private readonly IRepo _dl;

        public RRBL(IRepo repo)
        {
            _dl = repo;
        }

        /// <summary>
        /// Gets all restaurants
        /// </summary>
        /// <returns>list of all restaurants</returns>
        public List<Restaurant> GetAllRestaurants()
        {
            return _dl.GetAllRestaurants();
        }
        public void AddRestaurant(Restaurant restaurantToAdd)
        {
            if (restaurantToAdd.Name.Length < 4)
            {
                throw new InvalidOperationException("Restaurant name cannot have less than 4 character");
            }
            else
            {
                _dl.AddRestaurant(restaurantToAdd);
            }

        }
        public Restaurant GetRestaurant(string name)
        {
            return _dl.GetRestaurant(name);
        }
        public List<Restaurant> GetRestaurantByCity(string city)
        {
            return _dl.GetRestaurantByCity(city);
        }
        public List<Restaurant> GetRestaurantByRating(string rating)
        {
            return _dl.GetRestaurantByRating(rating);
        }
        public List<Restaurant> SearchRestaurants(string searchTerm)
        {

            if (searchTerm.ToLower() == "all")
            {
                return _dl.GetAllRestaurants();
            }
            else
            {
                return _dl.SearchRestaurants(searchTerm);
            }
        }
        public List<Restaurant> AVGRestaurants()
        {
            return _dl.AVGRestaurants();
        }
    }
}

