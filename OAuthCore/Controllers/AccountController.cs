using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace OAuthCore.Controllers
{
    public class AccountController : Controller
    {
        [Route("api/Account/Login")]
        public IActionResult LoginGithub()
        {
            return Challenge("GitHub");
            //return Challenge(new AuthenticationProperties { RedirectUri = "/" });
        }
    }
}