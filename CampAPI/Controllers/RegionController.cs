using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampAPI.Controllers
{
    public class RegionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
