using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewBL
{
    public class UserBL
    {
        public bool login(string login, string password)
        {
            bool retornoLogin = FileRepologin(login,password);
            if (retornoLogin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
