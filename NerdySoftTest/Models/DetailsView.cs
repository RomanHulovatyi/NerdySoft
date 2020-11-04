using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NerdySoftTest.Models;

namespace NerdySoftTest.Models
{
    public class DetailsView
    {
        public Announcement Announcement { get; set; }
        public List<Announcement> ListOfAnnouncements { get; set; }
    }
}
