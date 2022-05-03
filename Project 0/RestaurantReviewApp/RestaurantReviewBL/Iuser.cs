using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviewModels;

namespace RestaurantReviewBL
{
    internal interface Iuser
    {
        void AddUser(User user);
        User GetUser(string login);
        bool login(string login, string password);
    }
}
