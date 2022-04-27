using RestaurantReviewModels;

namespace RestaurantReviewDL
{
    public interface IRepo
    {
        List<Restaurant> GetAllRestaurants();

        void AddRestaurant(Restaurant restaurantToAdd);

        void AddReview(int restaurantId, Review reviewToAdd);

        List<Restaurant> SearchRestaurants(string searchTerm);

        bool IsDuplicate(Restaurant restaurant);

        /// <summary>
        /// Interface de metodo do login no banco de dados
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool login(string login, string password);
    }
}
