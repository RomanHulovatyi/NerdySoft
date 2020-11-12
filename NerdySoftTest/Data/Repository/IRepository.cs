using NerdySoftTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NerdySoftTest.Data.Repository
{
    public interface IRepository
    {
        Task<IndexViewModel> GetAllAnnouncementAsync(int page);
        Task<DetailsView> ViewDetailsAsync(int? id);
    }
}
