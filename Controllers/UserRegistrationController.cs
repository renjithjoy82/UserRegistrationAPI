using Microsoft.AspNetCore.Mvc;
//using System.Web.Http;
using UserRegistrationAPI.Data;
using UserRegistrationAPI.Models;


namespace UserRegistrationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRegistrationController : ControllerBase
    {
        private readonly UserDbContext _context;
        private readonly ILogger<UserRegistrationController> _logger;

        public UserRegistrationController(UserDbContext context, ILogger<UserRegistrationController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/Users/1
        [HttpGet("{id}")]
        public async Task<ActionResult<UserMaster>> GetUser(int id)
        {
            try
            {
                var user = await _context.Users.FindAsync(id);

                if (user == null)
                {
                    return NotFound();
                }

                return user;
            }
            catch (Exception ex)
            {
                _logger.LogTrace("Message: " + ex);
                return BadRequest(ex);
            }
        }

        // POST: api/Users
        [HttpPost]
        public ActionResult<UserMaster> PostEmaployee(UserMaster user)
        {
            try
            {
                if (user == null)
                {
                    return BadRequest();
                }

                user.DateofBirth = user.DateofBirth.HasValue ? user.DateofBirth.Value.AddDays(1) : (DateTime?)null;

                _context.Users.Add(user);
                _context.SaveChanges();

                return CreatedAtAction("GetUser", new { id = user.UserId }, user);  //(IHttpActionResult) Ok(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
