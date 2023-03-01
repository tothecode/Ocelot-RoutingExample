using Microsoft.AspNetCore.Mvc;
using UserService.Model;
using UserService.Services;

namespace UserService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("all")]
        public IEnumerable<User> Get()
        {
            return _userRepository.GetAll();
        }

        [HttpGet]
        public User? Get(int id)
        {
            return _userRepository.GetUser(id);
        }
    }
}