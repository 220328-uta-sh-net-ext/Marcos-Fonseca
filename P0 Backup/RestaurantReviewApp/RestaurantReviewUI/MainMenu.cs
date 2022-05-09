using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviewUI;
using RestaurantReviewModels;

namespace RestaurantReviewUI
{
    class MainMenu : IMenu
    {
        public void Display()
        {
            Console.WriteLine("Welcome to the best Restaurant Review App");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Press <3> Sign up");
            Console.WriteLine("Press <2> Sign in");
            Console.WriteLine("Press <1> Search Restaurant");
            Console.WriteLine("Press <0> Exit");
        }
        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return "Exit";
                case "1":
                    return "SearchRestaurant";
                case "2":
                    return "Singin";
                case "3":
                    return "Singup";
                default:
                    Console.WriteLine("Please enter a valid option");
                    Console.WriteLine("Please press ENTER to continue");
                    Console.ReadLine();
                    return "MainMenu";
            }

        }
    }
}
