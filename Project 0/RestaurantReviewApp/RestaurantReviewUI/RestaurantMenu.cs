using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewUI
{
    public class RestaurantMenu : IMenu
    {
        private IBL _bl;

        public RestaurantMenu(IBL bl)
        {
            _bl = bl;
        }
        public void Start()
        {
            throw new NotImplementedException();
        }
    }
}
