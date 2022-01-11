using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DYUCoreApp.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DYUCoreApp.Areas.Admin.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            var email = User.GetSpecificClaim("Email");
            return View();
        }
    }
}