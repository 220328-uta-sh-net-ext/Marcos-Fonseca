using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewModels
{
    public class User
    {
        public User()
        {
            id = 0;
            login = "a";
            firstName = "a";
            lastName = "a";
            email = "a@a.com";
            password = "a";
        }
        public int id { get; set; }
        private string login;
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                if (!(value.Length <= 4))
                {
                    login = value;
                }

            }

        }
        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    firstName = value;
                }
                else
                {
                    throw new Exception("Field first Name can not be empty");
                }
            }

        }

        private string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    lastName = value;
                }
                else
                {
                    throw new Exception("Field last name can not be empty");
                }
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                if (!(value.Length <= 4))
                {
                    password = value;
                }

            }


        }

        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    email = value;
                }
                else if (!value.Contains('@'))
                {
                    throw new Exception("Invalid e-mail format. Please try again.");

                }
                else
                {
                    throw new Exception("Field email can not be empty");
                }
            }
        }

    }
}

