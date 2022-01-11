using CampAdmin.Models;
using CampData;
using CampModel.Entity;
using CampService.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CampAdmin.Controllers
{
    public class CampController :Controller
    {
        private readonly CampDbContext _context;
        private readonly ICampingServices _service;
        public CampController(ICampingServices service, CampDbContext context)
        {
            _context = context;
            _service = service;
        }
        public IActionResult Index()
        {
            var list = _context.Camps.ToList();
            return View(list);
        }
        public IActionResult Publish(int Id)
        {
            var camp = _context.Camps.Find(Id);
            camp.IsPublish = true;
            _context.Update(camp);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Camp()
        {
            ViewBag.Region = _context.Regions.Select(w =>
            new SelectListItem
            {
                Text = w.Name,
                Value = w.Id.ToString()
            }).ToList();
            return View();
        }
        public async Task<IActionResult> DeleteCamp(int? Id)
        {
            Camp camp = await _context.Camps.FindAsync(Id);
            _context.Remove(camp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Camp));
        }
        [HttpPost]
        public async Task<IActionResult> Save(Camp model)
        {
            if (model != null)
            {
                var file = Request.Form.Files.First();
                string savePath = Path.Combine("C:", "Users", "BuseYalcin", "source", "repos", "CampingProject","CampUI", "wwwroot", "img");
                var fileName = $"{DateTime.Now:MMddHHmmss}.{file.FileName.Split(".").Last()}";
                var fileUrl = Path.Combine(savePath, fileName);
                using (var fileStream = new FileStream(fileUrl, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
                model.ImagePath = fileName;
                model.AuthorId = (int)HttpContext.Session.GetInt32("id");
                await _context.AddAsync(model);
                await _context.SaveChangesAsync();
                return Json(true);

            }

            return Json(false);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
