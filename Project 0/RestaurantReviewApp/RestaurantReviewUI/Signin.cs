using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviewBL;
using RestaurantReviewModels;

namespace RestaurantReviewUI
{
    class Signin : IMenu
    {
        public void Display()
        {
        }
        public void UserChoice()
        {
            User user = new User();

            Console.Write("Please enter your login");
            user.Login = Console.ReadLine();

            Console.Write("Please enter your password.");
            user.Password = Console.ReadLine();



        }
    }
}