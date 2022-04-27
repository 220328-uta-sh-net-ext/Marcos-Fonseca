using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviewBL;
using RestaurantReviewModels;

namespace RestaurantReviewUI
{
    class Signup : IMenu
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

            var result = new UserBL().login(user.Login, user.Password);

            if (result)
            {
                return "MainMenu";
            }

        }
    }
}
