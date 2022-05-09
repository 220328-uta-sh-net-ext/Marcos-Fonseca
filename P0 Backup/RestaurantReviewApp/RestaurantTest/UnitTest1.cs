using Xunit;
using RestaurantReviewBL;
using RestaurantReviewDL;
using RestaurantReviewModels;
using System.Collections.Generic;
using System;

namespace RestaurantTest
{

    public class UnitTest1
    {
        SqlRepository sqlRepository = new SqlRepository();
        [Fact]
        public void LoginTest()
        {
            string login = "Admin";
            string password = "Admin";
            var loginCheck = new UserBL(sqlRepository).login(login, password);

            Assert.True(loginCheck);
        }

        [Fact]
        public void GetUserTest()
        {
            string login = "ADMIN";
            var userCheck = new UserBL(sqlRepository).GetUser(login);

            Assert.NotNull(userCheck.FirstName);
        }

        [Fact]
        public void GetRestaurantTest()
        {
            string Name = "Brazilian BBQ";
            var RRCheck = new RRBL(sqlRepository).GetRestaurant(Name);

            Assert.NotNull(RRCheck.Name);
        }

        [Fact]
        public void GetAllRestaurantsTest()
        {
            var RRCheck = new RRBL(sqlRepository).GetAllRestaurants();

            Assert.NotNull(RRCheck[0].Phone);
        }

        [Fact]
        public void GetRestaurantByCityTest()
        {
            string Name = "New York";
            var RRCheck = new RRBL(sqlRepository).GetRestaurantByCity(Name);

            Assert.NotNull(RRCheck[0].Phone);
        }

        [Fact]
        public void AVGRestaurantsTest()
        {
            var RRCheck = new RRBL(sqlRepository).AVGRestaurants();

            Assert.NotNull(RRCheck[0].AVG);
        }


        [Fact]
        public void RestaurantReviewsTest()
        {
            string name = "TexMex";
            var RRCheck = new ReviewBL(sqlRepository).RestaurantReviews(name);

            Assert.NotNull(RRCheck[0].Rating);
        }

        [Fact]
        public void RestaurantAddTest()
        {
            Restaurant rest = new Restaurant()
            {
                Name = "a",
                City = "abcasdas",
                State = "sadasdsa",
                Phone = "123123123"
            };

            Assert.Throws<InvalidOperationException>(() => new RRBL(sqlRepository).AddRestaurant(rest));
        }

        [Fact]
        public void LoginAddTest()
        {
            User user = new User()
            {
                Login = "a",
                FirstName = "asd",
                LastName = "asdas",
                Email = "asdas@sadas.com",
                Password = "secret"
            };

            Assert.Throws<InvalidOperationException>(() => new UserBL(sqlRepository).AddUser(user));
        }

        [Fact]
        public void ReviewAddTest()
        {
            Review review = new Review()
            {
               score = 9,
               RestaurantId = 1,
               Comment = "test"
            };

            Assert.Throws<InvalidOperationException>(() => new ReviewBL(sqlRepository).AddReview(review));
        }

    }
}