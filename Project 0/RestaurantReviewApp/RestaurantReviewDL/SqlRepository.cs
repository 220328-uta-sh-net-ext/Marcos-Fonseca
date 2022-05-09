using RestaurantReviewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RestaurantReviewDL
{
    public class SqlRepository : IRepo
    {
        //private string connectionsStringFilePath = "../RestaurantReviewDL/connection-string.txt";
        private string connectionsStringFilePath = "../../../../RestaurantReviewDL/connection-string.txt";

        /// <summary>
        /// Get all the restaurants
        /// </summary>
        /// <returns>List of all restaurants</returns>
        public List<Restaurant> GetAllRestaurants()
        {
            string commandString = "SELECT * FROM Restaurant";

            var conn = File.ReadAllText(connectionsStringFilePath);
            using SqlConnection connection = new(conn);
            using SqlCommand command = new(commandString, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            var restaurants = new List<Restaurant>();
            while (reader.Read())
            {
                restaurants.Add(new Restaurant
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    City = reader.GetString(2),
                    State = reader.GetString(3),
                    Phone = reader.GetString(4)

                });
            }
            return restaurants;
        }

        /// <summary>
        /// Search restaurant by name
        /// </summary>
        /// <param name="name">The parameter must be the name of the restaurant</param>
        /// <returns>Return the restaurant details</returns>
        public Restaurant GetRestaurant(string name)
        {
            string commandString = "SELECT Top 1 * FROM Restaurant WHERE RestName = @name";

            var conn = File.ReadAllText(connectionsStringFilePath);
            using SqlConnection connection = new(conn);
            using SqlCommand command = new(commandString, connection);
            command.Parameters.AddWithValue("@name", name);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            var restaurant = new Restaurant();
            while (reader.Read())
            {
                restaurant.Id = reader.GetInt32(0);
                restaurant.Name = reader.GetString(1);
                restaurant.City = reader.GetString(2);
                restaurant.State = reader.GetString(3);
                restaurant.Phone = reader.GetString(4);
            }
            return restaurant;
        }

        /// <summary>
        /// Get Restaurant by City
        /// </summary>
        /// <param name="city"></param>
        /// <returns>Return the restaurant details by City</returns>
        public List<Restaurant> GetRestaurantByCity(string city)
        {
            string commandString = "SELECT * FROM Restaurant WHERE RestCity = @city";

            var conn = File.ReadAllText(connectionsStringFilePath);
            using SqlConnection connection = new(conn);
            using SqlCommand command = new(commandString, connection);
            command.Parameters.AddWithValue("@city", city);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            var restaurants = new List<Restaurant>();
            while (reader.Read())
            {
                restaurants.Add(new Restaurant
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    City = reader.GetString(2),
                    State = reader.GetString(3),
                    Phone = reader.GetString(4)

                });
            }
            return restaurants;
        }

        /// <summary>
        /// Get Restaurant By Rating
        /// </summary>
        /// <param name="rating"></param>
        /// <returns>Return the restaurant details by Rating</returns>
        public List<Restaurant> GetRestaurantByRating(string rating)
        {
            string commandString = "SELECT a.RestName AS RESTAURANT, AVG(b.Score) as AVG FROM Review b " +
                "INNER JOIN Restaurant a ON a.RestId = b.RestId " +
                "WHERE AVG = @rating " +
                "GROUP BY b.RestId,a.RestName;";

            var conn = File.ReadAllText(connectionsStringFilePath);
            using SqlConnection connection = new(conn);
            using SqlCommand command = new(commandString, connection);
            command.Parameters.AddWithValue("@rating", rating);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            var restaurant = new List<Restaurant>();
            while (reader.Read())
            {
                restaurant.Add(new Restaurant
                {

                    Name = reader.GetString(0),
                    AVG = reader.GetInt32(1)

                });
            }
            return restaurant;

        }
        /// <summary>
        /// Add a New Restaurant
        /// </summary>
        /// <param name="restaurantToAdd">Object type restaurant</param>
        public void AddRestaurant(Restaurant restaurantToAdd)
        {
            string commandString = "INSERT INTO Restaurant (RestName,RestCity,RestState,RestPhone) VALUES (@name,@city,@state,@phone)";

            var conn = File.ReadAllText(connectionsStringFilePath);
            using SqlConnection connection = new(conn);
            using SqlCommand command = new(commandString, connection);
            command.Parameters.AddWithValue("@name", restaurantToAdd.Name);
            command.Parameters.AddWithValue("@city", restaurantToAdd.City);
            command.Parameters.AddWithValue("@state", restaurantToAdd.State);
            command.Parameters.AddWithValue("@phone", restaurantToAdd.Phone);


            connection.Open();
            command.ExecuteNonQuery();
            //connection.Close();
        }

        /// <summary>
        /// Search a restaurant by filter
        /// </summary>
        /// <param name="searchTerm">Set the restaurant parameter</param>
        /// <returns>Return the list of restaurants by parameter</returns>
        public List<Restaurant> SearchRestaurants(string searchTerm)
        {
            string commandString = "SELECT * FROM Restaurant WHERE RestName = @searchTerm;";

            var conn = File.ReadAllText(connectionsStringFilePath);
            using SqlConnection connection = new(conn);
            using SqlCommand command = new(commandString, connection);
            command.Parameters.AddWithValue("@searchTerm", searchTerm);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            var restaurants = new List<Restaurant>();
            while (reader.Read())
            {
                restaurants.Add(new Restaurant
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    City = reader.GetString(2),
                    State = reader.GetString(3),
                    Phone = reader.GetString(4)

                });
            }
            return restaurants;
        }
        public List<Restaurant> AVGRestaurants()
        {
            string commandString = "SELECT a.RestName AS RESTAURANT, AVG(b.Score) as AVG FROM Review b " +
                "INNER JOIN Restaurant a ON a.RestId = b.RestId " +
                "GROUP BY b.RestId,a.RestName " +
                "ORDER BY AVG DESC;";

            var conn = File.ReadAllText(connectionsStringFilePath);
            using SqlConnection connection = new(conn);
            using SqlCommand command = new(commandString, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            var restaurant = new List<Restaurant>();
            while (reader.Read())
            {
                restaurant.Add(new Restaurant
                {

                    Name = reader.GetString(0),
                    AVG = reader.GetInt32(1)

                });
            }
            return restaurant;
        }

        /// <summary>
        /// Add a New Review
        /// </summary>
        /// <param name="reviewToAdd">Object type review</param>
        public void AddReview(Review reviewToAdd)
        {
            string commandString = "INSERT INTO Review (RestID,Score,Comment) VALUES (@restaurantId,@score,@comment)";

            var conn = File.ReadAllText(connectionsStringFilePath);
            using SqlConnection connection = new(conn);
            using SqlCommand command = new(commandString, connection);
            command.Parameters.AddWithValue("@restaurantId", reviewToAdd.RestaurantId);
            command.Parameters.AddWithValue("@score", reviewToAdd.score);
            command.Parameters.AddWithValue("@comment", reviewToAdd.Comment);


            connection.Open();
            command.ExecuteNonQuery();
        }
        /// <summary>
        /// Get Review
        /// </summary>
        /// <param name="restaurant"></param>
        /// <returns></returns>
        public List<Review> GetReviewRestaurant(Restaurant restaurant)
        {
            string commandString = "SELECT * FROM Review WHERE RestId = @searchTerm;";

            var conn = File.ReadAllText(connectionsStringFilePath);
            using SqlConnection connection = new(conn);
            using SqlCommand command = new(commandString, connection);
            command.Parameters.AddWithValue("@searchTerm", restaurant.Id);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            var review = new List<Review>();
            while (reader.Read())
            {
                review.Add(new Review
                {
                    Id = reader.GetInt32(0),
                    RestaurantId = reader.GetInt32(1),
                    score = reader.GetInt32(2),
                    Comment = reader.GetString(3)

                });
            }
            return review;
        }

        /// <summary>
        /// Add a New User
        /// </summary>
        /// <param name="user">Obeject type User</param>
        public void AddUser(User user)
        {
            string commandString = "INSERT INTO Login (Login,PASSWORD,Email,FirstName,LastName) VALUES (@login,@password,@email,@firstname,@lastname);";

            var conn = File.ReadAllText(connectionsStringFilePath);
            using SqlConnection connection = new(conn);
            using SqlCommand command = new(commandString, connection);
            command.Parameters.AddWithValue("@login", user.Login);
            command.Parameters.AddWithValue("@password", user.Password);
            command.Parameters.AddWithValue("@email", user.Email);
            command.Parameters.AddWithValue("@firstname", user.FirstName);
            command.Parameters.AddWithValue("@lastname", user.LastName);


            connection.Open();
            command.ExecuteNonQuery();
            //connection.Close();
        }

        /// <summary>
        /// Searh for an User
        /// </summary>
        /// <param name="login">Set the login parameter</param>
        /// <returns>Return the user by login</returns>
        public User GetUser(string login)
        {
            string commandString = "SELECT * FROM Login WHERE Login = @login";

            var conn = File.ReadAllText(connectionsStringFilePath);
            using SqlConnection connection = new(conn);
            using SqlCommand command = new(commandString, connection);
            command.Parameters.AddWithValue("@login", login);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            var user = new User();
            while (reader.Read())
            {
                user.id = reader.GetInt32(0);
                user.Login = reader.GetString(1);
                user.FirstName = reader.GetString(2);
                user.LastName = reader.GetString(3);
                user.Email = reader.GetString(4);
            }
            return user;
        }

        /// <summary>
        /// Check if the login exist
        /// </summary>
        /// <param name="login">Login parameter</param>
        /// <param name="password">Password parameter</param>
        /// <returns>Return true or false if there is an existing login</returns>
        public bool login(string login, string password)
        {

            bool exist;

            string commandString = "SELECT * FROM Login WHERE Login = @login AND PASSWORD = @password;";

            var conn = File.ReadAllText(connectionsStringFilePath);
            using SqlConnection connection = new(conn);
            using SqlCommand command = new(commandString, connection);
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@password", password);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            exist = reader.HasRows;

            return exist;
        }

    }
}


