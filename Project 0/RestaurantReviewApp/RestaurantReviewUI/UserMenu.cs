using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviewDL;

namespace RestaurantReviewUI
{
    public static class UserMenu
    {
        public static IMenu GetMenu(string menuString)
        {
            menuString = menuString.ToLower();

            IRepo repo = new FileRepo();
            IBL bl = new RRBL(repo);

            switch (menuString)
            {
                case "main":
                    return new MainMenu(bl);

                case "restaurant":
                    return new RestaurantMenu(bl);

                case "review":
                    return new NewUser(bl);

                default:
                    return new MainMenu(bl);
            }
        }
    }
}
