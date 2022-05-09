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
    class Signup : IMenu
    {
        SqlRepository sqlRepository = new SqlRepository();
        public void Display()
        {
        }
        public string UserChoice()
        {
            User user = new User();

            Console.Write("Please enter your login\n");
            user.Login = Console.ReadLine();
            var tama = user.Login.Length;
            Console.Write("Please enter your password.\n");
            user.Password = Console.ReadLine();
            Console.Write("Please enter your First Name.\n");
            user.FirstName = Console.ReadLine();
            Console.Write("Please enter your Last Name.\n");
            user.LastName = Console.ReadLine();
            Console.Write("Please enter your Email.\n");
            user.Email = Console.ReadLine();
            if (user.Email.Contains("@"))
            {
                new UserBL(sqlRepository).AddUser(user);
                Console.WriteLine("The user was successfully created.");
                Console.WriteLine("Press ENTER to continue ...");
                Console.ReadLine();
                return "Logged";
            }
            else
            {
                Console.WriteLine("Email is invalid format.");
                Console.WriteLine("Press ENTER to continue ...");
                Console.ReadLine();
                return "Singup";
            }

        }
    }
}
