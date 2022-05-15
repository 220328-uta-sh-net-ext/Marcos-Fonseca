using Microsoft.AspNetCore.Mvc;
using RestaurantReviewModels;
using RestaurantReviewBL;
using RestaurantReviewDL;

namespace RestaurantReviewApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantController : Controller
    {
        SqlRepository sqlRepository = new SqlRepository();

        [HttpGet("GetAllRestaurants")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<List<Restaurant>> GetAllRestaurants()
        {
            try
            {
                List<Restaurant> list = new RRBL(sqlRepository).GetAllRestaurants();
                if (list == null)
                {
                    return NotFound("There is no restaurant registered");
                }
                else
                {
                    return Ok(list);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddRestaurant")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult AddRestaurant([FromBody]Restaurant restaurant)
        {
            try
            {
                new RRBL(sqlRepository).AddRestaurant(restaurant);

                return Ok("Added");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetRestaurant")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult GetRestaurant([FromQuery] String restaurantName)
        {
            try
            {
                Restaurant restaurant = new RRBL(sqlRepository).GetRestaurant(restaurantName);
                if (restaurant == null)
                {
                    return NotFound(restaurantName + " Restaurant Not Found.");
                }
                else
                {
                    return Ok(restaurant);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("SearchRestaurants")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<List<Restaurant>>SearchRestaurants([FromQuery] String restaurantName)
        {
            try
            {
                List<Restaurant> restaurant = new RRBL(sqlRepository).SearchRestaurants(restaurantName);
                if (restaurant == null)
                {
                    return NotFound(restaurantName + " Restaurant Not Found.");
                }
                else
                {
                    return Ok(restaurant);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("AVGRestaurants")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<List<Restaurant>> AVGRestaurants()
        {
            try
            {
                List<Restaurant> restaurants = new RRBL(sqlRepository).AVGRestaurants();
                if (restaurants == null)
                {
                    return NotFound("Not Found.");
                }
                else
                {
                    return Ok(restaurants);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetRestaurantByCity")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<List<Restaurant>> GetRestaurantByCity([FromQuery] string city)
        {
            try
            {
                List<Restaurant> restaurants = new RRBL(sqlRepository).GetRestaurantByCity(city);
                if (restaurants == null)
                {
                    return NotFound("Not Found.");
                }
                else
                {
                    return Ok(restaurants);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetRestaurantByRating")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<List<Restaurant>> GetRestaurantByRating([FromQuery] string rating)
        {
            try
            {
                List<Restaurant> restaurants = new RRBL(sqlRepository).GetRestaurantByRating(rating);
                if (restaurants == null)
                {
                    return NotFound("Not Found.");
                }
                else
                {
                    return Ok(restaurants);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



    }
}
