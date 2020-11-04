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
using NerdySoftTest.Models;


namespace NerdySoftTest.Controllers
{
    public class HomeController : Controller
    {
        AnnouncementContext db;
        public HomeController(AnnouncementContext context)
        {
            db = context;
        }

        public async Task<IActionResult> IndexAsync(int page=1)
        {
            int pageSize = 4;

            IQueryable<Announcement> source = db.Announcements.OrderByDescending(t => t.DateAdded);
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Announ = items
            };
            return View(viewModel);
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
            if (id != null)
            {
                Announcement announcement = await db.Announcements.FirstOrDefaultAsync(p => p.Id == id);
                var splitedTitle = announcement.Title.Split(" ");
                List<Announcement> temp = new List<Announcement>(); 
                foreach (var word in splitedTitle)
                {
                    temp.AddRange(db.Announcements.Where(x => x.Title.ToLower().Contains(word.ToLower()) && x.Id != id).ToList());
                }
                if(announcement.Description != null)
                {
                    var splitedDescription = announcement.Description.Split(" ");
                    List<Announcement> tempo = new List<Announcement>();
                    foreach (var word in splitedDescription)
                    {
                        temp.AddRange(db.Announcements.Where(x => x.Description.ToLower().Contains(word.ToLower()) && x.Id != id).ToList());
                    }
                }
                
                DetailsView source = new DetailsView { Announcement = announcement, ListOfAnnouncements = temp.Take(3).ToList() };
                if (announcement != null)
                    return View(source);
            }
            return NotFound();
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

            ViewData["message"] = "Blog post edited successfully.";
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
