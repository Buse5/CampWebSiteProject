using CampData;
using CampService;
using CampUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CampModel.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CampService.Abstract;

namespace CampUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly CampDbContext _context;
        private readonly ICampingServices _service;
        public HomeController(ICampingServices service,CampDbContext context)
        {
            _context = context;
            _service = service;
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Offer()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Index()
        {
            var list = _context.Camps.Where(b => b.IsPublish).OrderByDescending(x => x.CreateDate).ToList();
            foreach (var camp in list)
            {
                camp.Author = _context.Authors.Find(camp.AuthorId);
            }
            return View(list);
        }

        public IActionResult Post(int Id)
        {
            var camp = _context.Camps.Find(Id);
            camp.Author = _context.Authors.Find(camp.AuthorId);
            camp.ImagePath = "/img/" + camp.ImagePath;
            return View(camp);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
