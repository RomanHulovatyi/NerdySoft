using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace NerdySoftTest.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Announcement> Announ{ get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
