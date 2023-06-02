using Ecom_Project_1030.Data;
using Ecom_Project_1030.DataAccess.Repository.iRepository;
using Ecom_Project_1030.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom_Project_1030.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, iCoverTypeRepository
    {
        private readonly ApplicationDbContext _context;
        public CoverTypeRepository(ApplicationDbContext context):base (context)
        {
            _context = context;
        }
        public void Update(CoverType coverType)
        {
            _context.Update(coverType);
        }
    }
}
