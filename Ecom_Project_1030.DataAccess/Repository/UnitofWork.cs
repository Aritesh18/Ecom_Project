using Ecom_Project_1030.Data;
using Ecom_Project_1030.DataAccess.Repository.iRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom_Project_1030.DataAccess.Repository
{
    public class UnitofWork : iUnitofWork
    {
        private readonly ApplicationDbContext _context;
        public UnitofWork(ApplicationDbContext context)
        {
            _context = context;
            category = new CategoryRepository(_context);
            covertype = new CoverTypeRepository(_context);
            SP_CALL = new SP_CALL(_context);
            product = new ProductRepository(_context);
            company = new CompanyRepository(_context);
            ApplicationUser = new ApplicationRepository(_context);
            shoppingCart = new ShoppingCartRepository(_context);
            OrderHeader = new OrderHeaderRepository(_context);
            OrderDetails = new OrderDetailsRepository(_context);

        }
        public iCategoryRepository category { get; private set; }

        public iCoverTypeRepository covertype { get; private set; }
        public iOrderHeaderRepository OrderHeader { get; set; }
        public ISP_CALL SP_CALL { get; private set; }
        public iProductRepository product { get; private set; }
        public iCompanyRepository company { get; private set; }

        public iApplicationUserRepository ApplicationUser { get; private set; }

        public iShoppingCartRepository shoppingCart { get; private set; }

        public iOrderDetailsRepository OrderDetails { get; private set; }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
