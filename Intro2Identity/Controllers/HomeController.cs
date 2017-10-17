using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intro2Identity.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
