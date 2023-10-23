using Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Repository.UserRepository;

namespace WebApiToDeploy.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UserController
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost("Create")]
        public async Task<bool> Create(User user)
        {
            return await _userRepository.Insert(user);
        }
        [HttpGet("GetAll")]
        public async Task<IEnumerable<User>> GetAll()
        {
            return await _userRepository.GetAll();
        }
        [HttpGet("GetAll2")]
        public string GetAll2()
        {
            return "egarii";
        }
    }
}
