using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NerdySoftTest.Models
{
    public class Announcement
    {
        [Required]
        public int Id { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
    }
}
