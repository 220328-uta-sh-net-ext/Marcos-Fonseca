using RestaurantReviewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace RestaurantReviewDL
{
    public class FileRepo : IRepo
    {
            public FileRepo()
            { }

            private string filePath = "../RestaurantReviewDL/Restaurants.json";
            private string jsonString;

            public List<Restaurant> GetAllRestaurants()
            {
                throw new NotImplementedException();
            }

            public void AddRestaurant(Restaurant restaurantToAdd)
            {
                throw new NotImplementedException();
            }

            public void AddReview(int restaurantId, Review reviewToAdd)
            {
                throw new NotImplementedException();
            }

            public List<Restaurant> SearchRestaurants(string searchTerm)
            {
                throw new NotImplementedException();
            }

            public bool IsDuplicate(Restaurant restaurant)
            {
                throw new NotImplementedException();
            }
            public bool login(string login, string password)
            {
                throw new NotImplementedException();
            }

    }

}