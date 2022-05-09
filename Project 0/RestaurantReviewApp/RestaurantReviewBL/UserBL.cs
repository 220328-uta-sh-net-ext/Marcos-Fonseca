using RestaurantReviewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviewDL;

namespace RestaurantReviewBL
{
    public class UserBL : Iuser
    {
        private readonly IRepo _dl;

        public UserBL(IRepo repo)
        {
            _dl = repo;
        }



        /// <summary>
        /// Check if the login exist
        /// </summary>
        /// <param name="login">Login parameter</param>
        /// <param name="password">Password parameter</param>
        /// <returns>Return true or false if there is an existing login</returns>
        public bool login(string login, string password)
        {
            return _dl.login(login, password);
        }

        public void AddUser(User user)
        {
            if (user.Login.Length < 2)
            {
                throw new InvalidOperationException("Login cannot have less than 2 character");
            }
            else
            {
                _dl.AddUser(user);
            }

        }

        public User GetUser(string login)
        {
            return _dl.GetUser(login);
        }


    }
}
