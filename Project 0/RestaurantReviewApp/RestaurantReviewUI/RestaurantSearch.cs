using RestaurantReviewBL;
using RestaurantReviewDL;
using RestaurantReviewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewUI
{
    internal class RestaurantSearch : IMenu
    {
        SqlRepository sqlRepository = new SqlRepository();
        public void Display()
        {
            Console.WriteLine("Please select an option to filter the restaurant list");
            Console.WriteLine("Press <3> By Name");
            Console.WriteLine("Press <2> By City");
            Console.WriteLine("Press <1> By Rating");
            Console.WriteLine("Press <0> Go Back");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return "MainMenu";
                case "1":
                    List<Restaurant> restaurantsAVG = new RRBL(sqlRepository).AVGRestaurants();
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("Name  |  AVG ");
                    Console.WriteLine("------------------------------------------------------------");
                    foreach (var item in restaurantsAVG)
                    {
                        Console.WriteLine("------------------------------------------------------------");
                        Console.WriteLine("{0}  |  {1}  ", item.Name, item.AVG);
                        Console.WriteLine("------------------------------------------------------------");
                    }
                    Console.WriteLine("Press ENTER to continue ...");
                    Console.ReadLine();

                    return "SearchRestaurant";
                case "2":
                    Console.WriteLine("Please choose a restaurant");
                    string searchTerm = Console.ReadLine();
                    List<Restaurant> restaurants = new RRBL(sqlRepository).GetRestaurantByCity(searchTerm);
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
                    return "SearchRestaurant";
                case "3":
                    Console.WriteLine("Please type the restaurant name");
                    searchTerm = Console.ReadLine();
                    Restaurant restaurant = new RRBL(sqlRepository).GetRestaurant(searchTerm);

                    if (restaurant.Name != "")
                    {
                        Console.WriteLine("------------------------------------------------------------");
                        Console.WriteLine("Name  |  City  |  State | Phone");
                        Console.WriteLine("------------------------------------------------------------");
                        Console.WriteLine("------------------------------------------------------------");
                        Console.WriteLine("{0}  |  {1}  |  {2} | {3}", restaurant.Name, restaurant.City, restaurant.State, restaurant.Phone);
                        Console.WriteLine("------------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("Restaurant not found.");
                    }
                    Console.WriteLine("Press ENTER to continue ...");
                    Console.ReadLine();
                    return "SearchRestaurant";
                default:
                    Console.WriteLine("Please enter a valid response");
                    Console.WriteLine("Please press <enter> to continue");
                    Console.ReadLine();
                    return "SearchRestaurant";
            }
        }
    }
}

