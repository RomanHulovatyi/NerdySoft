using NerdySoftTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NerdySoftTest
{
    public static class Sample
    {
        public static void Initialize(AnnouncementContext context)
        {
            if (!context.Announcements.Any())
            {
                context.Announcements.AddRange(
                    new Announcement { Title = "Shakhtar Donetsk - Mönchengladbach", Description = "Football match", DateAdded = DateTime.Now },
                    new Announcement { Title = "Lokomotiv Moskva - Atlético", Description = "Football match", DateAdded = DateTime.Now },
                    new Announcement { Title = "Salzburg - Bayern", Description = "Football match", DateAdded = DateTime.Now },
                    new Announcement { Title = "Real Madrid - Internazionale", Description = "Football match", DateAdded = DateTime.Now },
                    new Announcement { Title = "Man. City - Olympiacos", Description = "Football match", DateAdded = DateTime.Now },
                    new Announcement { Title = "Porto - Marseille", Description = "Football match", DateAdded = DateTime.Now },
                    new Announcement { Title = "Midtjylland - Ajax", Description = "Football match", DateAdded = DateTime.Now },
                    new Announcement { Title = "Atalanta - Liverpool", Description = "Football match", DateAdded = DateTime.Now }
                    );
                context.SaveChanges();
            }
        }
    }
}
