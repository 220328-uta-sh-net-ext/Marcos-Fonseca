using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewModels
{
    public class Review
    {

        public Review() { }


        public Review(int rating)
        {
            this.Rating = rating;
        }

        public Review(int rating, int note)
        {
            this.Rating = rating;
            this.score = note;
        }

        public int Id { get; set; }

        public int RestaurantId { get; set; }


        private int _rating;
        public int Rating
        {
            get => _rating;

            set
            {
                if (value <= 0 || value > 5)
                {
                    throw new InputInvalidException("Score must be between 1 and 5");
                }
                this._rating = value;
            }
        }
        public int score { get; set; }

        public string Comment { get; set; }

        public override string ToString()
        {
            return $"Rating: {this.Rating} \t Note: {this.score}";
        }
    }
}
