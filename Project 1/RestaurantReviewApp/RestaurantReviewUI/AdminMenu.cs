using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviewBL;
using RestaurantReviewDL;
using RestaurantReviewModels;

namespace RestaurantReviewUI
{
    class AdminMenu : IMenu
    {
        SqlRepository sqlRepository = new SqlRepository();
        public void Display()
        {
            Console.WriteLine("Welcome to the Admin Menu");
            Console.WriteLine("Please select an option...");
            Console.WriteLine("Press <6> Add New Restaurant");
            Console.WriteLine("Press <5> Search user");
            Console.WriteLine("Press <4> Add review to a restaurant");
            Console.WriteLine("Press <3> View reviews of restaurants");
            Console.WriteLine("Press <2> View the average rating for each restaurant"); // Retorna a media das avaliacoes do restaurante
            Console.WriteLine("Press <1> Search restaurant");
            Console.WriteLine("Press <0> Exit");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return "MainMenu";
                case "1":
                    Console.WriteLine("Type the restaurant name or 'All' to display all the restaurants");
                    string searchTerm = Console.ReadLine();
                    var restaurants = new RRBL(sqlRepository).SearchRestaurants(searchTerm);
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("Name  |  City  |  State | Phone");
                    Console.WriteLine("------------------------------------------------------------");
                    foreach (var item in restaurants)
                    {
                        Console.WriteLine("------------------------------------------------------------");
                        Console.WriteLine("{0}  |  {1}  |  {2} | {3}", item.Name, item.City, item.State, item.Phone);
                        Console.WriteLine("------------------------------------------------------------");
                    }
                    Console.WriteLine("Press ENTER to continue ...");
                    Console.ReadLine();
                    return "MenuAdmin";
                case "2":
                    restaurants = new RRBL(sqlRepository).AVGRestaurants();
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("Name  |  AVG  ");
                    Console.WriteLine("------------------------------------------------------------");
                    foreach (var item in restaurants)
                    {
                        Console.WriteLine("------------------------------------------------------------");
                        Console.WriteLine("{0}  |  {1}   ", item.Name, item.AVG);
                        Console.WriteLine("------------------------------------------------------------");
                    }
                    Console.WriteLine("Press ENTER to continue ...");
                    Console.ReadLine();
                    return "MenuAdmin"; //retorna para de usuario
                case "3":
                    Console.WriteLine("Please type the restaurant name");
                    searchTerm = Console.ReadLine();
                    var reviews = new ReviewBL(sqlRepository).RestaurantReviews(searchTerm);
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("Score  |  Comments  ");
                    Console.WriteLine("------------------------------------------------------------");
                    foreach (var item in reviews)
                    {
                        Console.WriteLine("------------------------------------------------------------");
                        Console.WriteLine("{0}  |  {1}  ", item.score, item.Comment);
                        Console.WriteLine("------------------------------------------------------------");
                    }
                    Console.WriteLine("Press ENTER to continue ...");
                    Console.ReadLine();
                    return "MenuAdmin"; //retorna para de usuario 

                case "4":
                    Console.WriteLine("Please type the restaurant name");
                    searchTerm = Console.ReadLine();
                    Restaurant restaurant = new RRBL(sqlRepository).GetRestaurant(searchTerm);
                    Console.WriteLine(" Restaurant : {0}", restaurant.Name);
                    Console.WriteLine("Please type the Score");
                    string score = Console.ReadLine();
                    Console.WriteLine("Please type a comment (Optional)");
                    string comment = Console.ReadLine();
                    Review review = new Review();
                    review.score = Convert.ToInt32(score);
                    review.Comment = comment;
                    review.RestaurantId = restaurant.Id;
                    new ReviewBL(sqlRepository).AddReview(review);

                    Console.WriteLine("Review Successfully Added.");
                    Console.WriteLine("Press ENTER to continue ...");
                    Console.ReadLine();
                    return "MenuAdmin"; //retorna para de usuario
                case "5":
                    var user = new User();
                    Console.WriteLine("Please enter the user Login");
                    string userlogin = Console.ReadLine();

                    user = new UserBL(sqlRepository).GetUser(userlogin);
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("Login  |  Firstname  |  LastName  |  Email  ");
                    Console.WriteLine("------------------------------------------------------------");

                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("{0}  |  {1} | {2}  |  {3}  ", user.Login, user.FirstName, user.LastName, user.Email);
                    Console.WriteLine("------------------------------------------------------------");

                    Console.WriteLine("Press ENTER to continue ...");
                    Console.ReadLine();
                    return "MenuAdmin";

                case "6":

                    restaurant = new Restaurant();
                    Console.WriteLine("Please enter the restaurant name");
                    restaurant.Name = Console.ReadLine();
                    Console.WriteLine("Please enter the restaurant city location");
                    restaurant.City = Console.ReadLine();
                    Console.WriteLine("Please enter the restaurant state location");
                    restaurant.State = Console.ReadLine();
                    Console.WriteLine("Please enter the restaurant phone");
                    restaurant.Phone = Console.ReadLine();

                    try
                    {
                        Log.Information("Adding a restaurant: " + restaurant.Name);
                        new RRBL(sqlRepository).AddRestaurant(restaurant);
                        Log.Information("Restaurant Successfully Added.");
                    }
                    catch (Exception ex)
                    {
                        Log.Error("Failed to add restaurant");
                        Console.Write(ex.Message);
                        Console.WriteLine("Please enter a valid response");
                    }

                    Console.WriteLine("Restaurant Successfully Added.");
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadLine();
                    return "MenuAdmin";
                default:
                    Console.WriteLine("Please enter a valid response");
                    Console.WriteLine("Please press <enter> to continue");
                    Console.ReadLine();
                    return "MenuAdmin";
            }
        }
    }
}

