using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserRegistrationAPI.Data;
using UserRegistrationAPI.Models;

namespace UserRegistrationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatesController : ControllerBase
    {
        private readonly UserDbContext _context;

        public StatesController(UserDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StateMaster>>> StateList()
        {
            try
            {
                var stateList = await _context.StateLists.ToListAsync();

                return stateList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
