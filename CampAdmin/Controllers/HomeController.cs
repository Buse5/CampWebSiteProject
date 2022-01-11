using CampAdmin.Models;
using CampData;
using CampModel.Entity;
using CampService.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CampAdmin.Controllers
{
    public class HomeController : Controller
    {
        private readonly CampDbContext _context;
        private readonly ICampingServices _service;

        public HomeController(ICampingServices service, CampDbContext context)
        {           
            _context = context;
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
           
        }
        public IActionResult Region()
        {
            List<Region> regions = _context.Regions.ToList();
            return View(regions);
        }
        public IActionResult Author()
        {
            List<Author> list = _context.Authors.ToList();
            return View(list);
        }
        public IActionResult Login(string Email, string Password)
        {
            var author = _context.Authors.FirstOrDefault(w => w.Email == Email && w.Password == Password);
            if (author == null)
            {
                return RedirectToAction(nameof(Index));

            }

            HttpContext.Session.SetInt32("id", author.Id);

            return RedirectToAction(nameof(Region));
        }

        public async Task<IActionResult> AddAuthor(Author author)
        {
            if (author.Id == 0)
            {
                await _context.AddAsync(author);
            }
            else
            {
                _context.Update(author);
            }
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Author));
        }
        public async Task<IActionResult> AuthorDetails(int Id)
        {
            var author = await _context.Authors.FindAsync(Id);
            return Json(author);
        }
        public async Task<IActionResult> DeleteAuthor(int? Id)
        {
            var author = await _context.Authors.FindAsync(Id);
            _context.Remove(author);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Author));
        }



        public async Task<IActionResult> DeleteRegion(int? Id)
        {
            Region region = await _context.Regions.FindAsync(Id);
            _context.Remove(region);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Region));
        }

        public async Task<IActionResult> RegionDetails(int Id)
        {
            var region = await _context.Regions.FindAsync(Id);
            return Json(region);
        }
        public IActionResult LogOut()
        {

            HttpContext.Session.Clear();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> AddRegion(Region region)
        {
            if (region.Id == 0)
            {
                await _context.AddAsync(region);
            }
            else
            {
                _context.Update(region);
            }
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(region));
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
