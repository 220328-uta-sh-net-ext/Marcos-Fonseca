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
            login = "johndoe";
            firstName = "John";
            lastName = "Doe";
            email = "john@doe.com";
            password = "123456";
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
                if (!(value.Length <= 8))
                {
                    password = value;
                }
                else
                {
                    throw new Exception("At least 8 characters required.");
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
                    throw new Exception("First Name can not be empty");
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
                    throw new Exception("Last Name can not be empty");
                }
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                if (!(value.Length <= 8))
                {
                    password = value;
                }
                else
                {
                    throw new Exception("At least 8 characters required.");
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
                    throw new Exception("invalid e-mail");

                }
                else
                {
                    throw new Exception("e-mail can not be empty");
                }
            }
        }

    }
}

