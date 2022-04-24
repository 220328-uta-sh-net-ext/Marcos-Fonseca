using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewUI
{
    public class ReviewMenu : IMenu
    {
        private readonly IBL _bl;
        public ReviewMenu(IBL bl)
        {
            _bl = bl;
        }
        public void Start() { }

    }
}
