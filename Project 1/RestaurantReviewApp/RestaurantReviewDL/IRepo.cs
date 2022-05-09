using RestaurantReviewModels;
using System.Data.SqlClient;

namespace RestaurantReviewDL
{
    public interface IRepo
    {
        List<Restaurant> GetAllRestaurants();
        void AddRestaurant(Restaurant restaurantToAdd);
        void AddReview(Review reviewToAdd);
        List<Review> GetReviewRestaurant(Restaurant restaurant);
        Restaurant GetRestaurant(string name);
        List<Restaurant> SearchRestaurants(string searchTerm);
        List<Restaurant> GetRestaurantByCity(string city);
        List<Restaurant> GetRestaurantByRating(string rating);
        List<Restaurant> AVGRestaurants();
        void AddUser(User user);
        User GetUser(string login);
        bool login(string login, string password);
    }
}
