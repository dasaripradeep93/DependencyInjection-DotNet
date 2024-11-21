using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class DependencyInjectonController : Controller
    {
        private readonly IUserService _userService;
        public DependencyInjectonController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("GetUsers")]
        public void GetUsers()
        {
            _userService.AddUser();
        }

        [HttpGet]
        [Route("GetExternalUsers")]
        public void GetExtUsers()
        {
            _userService.AddUser();
        }
    }
}
