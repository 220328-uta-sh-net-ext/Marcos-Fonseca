using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviewBL;
using RestaurantReviewModels;
using RestaurantReviewDL;

namespace RestaurantReviewUI
{
    class Signin : IMenu
    {
        SqlRepository sqlRepository = new SqlRepository();
        public void Display()
        {

        }
        public string UserChoice()
        {
            User user = new User();

            Console.Write("Please enter your login: \n");
            user.Login = Console.ReadLine();

            Console.Write("Please enter your password: \n");
            user.Password = Console.ReadLine();


            if (new UserBL(sqlRepository).login(user.Login, user.Password))
            {
                string menu = "";
                if (user.Login.ToLower() == "admin")
                {
                    return "MenuAdmin";
                }
                else
                {
                    return "Logged";
                }

            }
            else
            {
                Console.Write("Invalid Login or Password. Please try again.\n");
                Console.ReadLine();
                return "Singin";
            }
        }
    }
}