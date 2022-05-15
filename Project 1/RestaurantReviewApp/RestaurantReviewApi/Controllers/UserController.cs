using Microsoft.AspNetCore.Mvc;
using RestaurantReviewModels;
using RestaurantReviewBL;
using RestaurantReviewDL;

namespace RestaurantReviewApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        SqlRepository sqlRepository = new SqlRepository();

        [HttpGet("GetUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<User> GetUser([FromQuery] string login)
        {
            try
            {
                User user = new UserBL(sqlRepository).GetUser(login);
                if (user == null)
                {
                    return NotFound("There is no User in Database");
                }
                else
                {
                    return Ok(user);
                }
        
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<bool> Login([FromBody] String login, String Password)
        {
            try
            {
                var logged = new UserBL(sqlRepository).login(login, Password);
                if (!logged)
                {
                    return NotFound("There is no User in Database");
                }
                else
                {
                    return Ok(logged);
                }
        
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpPost("AddUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<User> AddUser([FromBody] User user)
        {
            try
            {
                new UserBL(sqlRepository).AddUser(user);
        
                return Ok("Added");
        
        
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
