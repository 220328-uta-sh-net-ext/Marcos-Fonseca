using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewModels
{
    public class Restaurant
    {
<<<<<<< HEAD
=======
        //In a restaurant, I want to store name, city, state of a restaurant

        //This is property, a type member
        //Access modifier controls the visibility of type and type members.
        //There are four access modifiers: Public, Private, Internal, Protected
        //public is the most visible, private is the least visible
        //By default, class member has private access modifier
        //Class, by default, are internal unless you explicitely say otherwise

        public Restaurant()
        {
            this.Reviews = new List<Review>();
        }
        public Restaurant(string name)
        {
            this.Reviews = new List<Review>();
            this._name = name;
        }

        /// <summary>
        /// Converting Restaurant table's data row into Restaurant Object
        /// </summary>
        /// <param name="row">a data row from Restaurant object, must have id, name, city, state columns</param>
        public Restaurant(DataRow row)
        {
            this.Id = (int)row["Id"];
            this.Name = row["Name"].ToString() ?? "";
            this.City = row["City"].ToString() ?? "";
            this.State = row["State"].ToString() ?? "";
            //this.Comment = row["Comment"].ToString() ?? "";
        }

>>>>>>> f8e59d130539369c719918d0794d2cdfcb5711ce
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
<<<<<<< HEAD
        public string Phone { get; set; }
        public int AVG { get; set; }

=======
        //public string Comment { get; set; }
        public List<Review> Reviews { get; set; }

        public override string ToString()
        {
            return $"Id: {this.Id} \nName: {this.Name} \nCity: {this.City} \nState: {this.State} \nComment: {this.Comment}";
        }

        /// <summary>
        /// Takes in Restaurant Table's DataRow and fills the columns with the Restaurant Instance's info
        /// </summary>
        /// <param name="row">Restaurant Table's DataRow pass by ref</param>
        public void ToDataRow(ref DataRow row)
        {
            row["Name"] = this.Name;
            row["City"] = this.City;
            row["State"] = this.State;
            //row["comment"] = this.Comment;
        }
>>>>>>> f8e59d130539369c719918d0794d2cdfcb5711ce
    }

}
