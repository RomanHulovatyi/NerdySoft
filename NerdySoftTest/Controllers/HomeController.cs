using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NerdySoftTest.Data.Repository;
using NerdySoftTest.Models;


namespace NerdySoftTest.Controllers
{
    public class HomeController : Controller
    {
        AnnouncementContext db;
        IRepository repo;
        public HomeController(AnnouncementContext context, IRepository repo)
        {
            db = context;
            this.repo = repo;
        }

        public async Task<IActionResult> IndexAsync(int page = 1)
        {
            var announcements = await repo.GetAllAnnouncementAsync(page);
            return View(announcements);
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add (Announcement announcement)
        {
            db.Announcements.Add(announcement);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        
        public async Task<IActionResult> Details(int? id)
        {
            var view = await repo.ViewDetailsAsync((int)id);
            return View(view);
        }

        [HttpGet]
        public ViewResult Edit(int Id)
        {
            Announcement announcement = db.Announcements.Where(x => x.Id == Id).FirstOrDefault();
            if (announcement == null)
            {
                ViewData["message"] = "Announcement not found.";
                return View("Index");
            }
            return View(announcement);
        }
        [HttpPost]
        public IActionResult Edit(int? id)
        {
            var announcement = db.Announcements.Single(p => p.Id == id);
            TryUpdateModelAsync(announcement);

            if (!ModelState.IsValid)
                return View("Edit");

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfrimDelete(int? id)
        {
            if (id != null)
            {
                Announcement announcement = await db.Announcements.FirstOrDefaultAsync(p => p.Id == id);
                if (announcement != null)
                    return View(announcement);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Announcement announcement = await db.Announcements.FirstOrDefaultAsync(p => p.Id == id);
                if (announcement != null)
                {
                    db.Announcements.Remove(announcement);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
