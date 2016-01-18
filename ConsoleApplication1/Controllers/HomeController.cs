using System.Web.Http;
using AppIdentityExample.Models;
using Microsoft.AspNet.Identity;

namespace AppIdentityExample.Controllers
{
    public class HomeController : ApiController
    {
        private readonly AppUserManager _appUserManager;

        public HomeController(AppUserManager appUserManager)
        {
            _appUserManager = appUserManager;
        }

        [HttpPost]
        public string Login(LoginViewModel login)
        {
            AppUser user = _appUserManager.Find(login.User, login.Password);

            //Logic for verify user exists

            return "User auth";
        }

        public string Get()
        {
            return "testing";
        }
    }
}