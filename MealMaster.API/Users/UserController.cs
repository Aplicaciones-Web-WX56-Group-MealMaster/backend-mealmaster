using Microsoft.AspNetCore.Mvc;

namespace BasePlatform.API.Users
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetById(int id)
        {
            var user = _userService.GetById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public ActionResult Add(User users)
        {
            _userService.Add(users);
            return CreatedAtAction(nameof(GetById), new { id = users.Id }, users);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, User users)
        {
            if (id != users.Id)
            {
                return BadRequest();
            }

            _userService.Update(users);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _userService.Delete(id);
            return NoContent();
        }
    }
}