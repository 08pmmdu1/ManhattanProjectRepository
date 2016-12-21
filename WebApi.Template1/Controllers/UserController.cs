using ManhattanProject.Models.Entities;
using ManhattanProject.Services.Interfaces;
using System.Web.Http;
using WebApi.Template1.App_Start;

namespace ManhattanProject.WebApi.Controllers
{
    public class UserController : ApiController
    {
        private IUserService _userService;


        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [Route("api/user/{email}")]
        public User GetUserByEmail(string email)
        {
            return _userService.GetUserByEmail(email);
        }


    }
}
