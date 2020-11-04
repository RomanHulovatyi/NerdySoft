using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NerdySoftTest.Models
{
    public class PageViewModel
    {
        public int PageNumber { get; private set; }  
        public int TotalPages { get; private set; }
        public PageViewModel(int count, int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize); 
        }
        public bool HasNextPage
        {
            get
            {
                return (PageNumber < TotalPages);
            }
        }
        public bool HasPreviousPage
        {
            get
            {
                return (PageNumber > 1);
            }
        }
    }
}
