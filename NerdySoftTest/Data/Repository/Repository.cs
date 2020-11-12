using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NerdySoftTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdySoftTest.Data.Repository
{
    public class Repository : IRepository
    {
        private AnnouncementContext db;

        public Repository(AnnouncementContext context)
        {
            db = context;
        }

        public async Task<IndexViewModel> GetAllAnnouncementAsync(int page = 1)
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
            return viewModel;
        }

        public async Task<DetailsView> ViewDetailsAsync(int? id)
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
                if (announcement.Description != null)
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
                    return source;
            }
            return new DetailsView();
        }
    }
}
