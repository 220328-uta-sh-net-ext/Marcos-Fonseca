using Microsoft.AspNetCore.Mvc;
using RestaurantReviewModels;
using RestaurantReviewBL;
using RestaurantReviewDL;

namespace RestaurantReviewApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReviewController : ControllerBase
    {
        SqlRepository sqlRepository = new SqlRepository();

        [HttpGet("GetList")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<List<Review>> GetList([FromQuery] string restaurantName)
        {
            try
            {
                List<Review> list = new ReviewBL(sqlRepository).RestaurantReviews(restaurantName);
                if (list == null)
                {
                    return NotFound("There is no Restaurant in Database");
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

        [HttpPost("AddReview")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult AddReview([FromQuery]string restaurantName, Review review )
        {
            try
            {
                Restaurant restaurant = new RRBL(sqlRepository).GetRestaurant(restaurantName);

                if (restaurant != null)
                {
                    review.RestaurantId = restaurant.Id;
                    new ReviewBL(sqlRepository).AddReview(review);
                    return Ok("Review Added");

                }
                else
                {
                    return NotFound("There is no Restaurant in Database");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
