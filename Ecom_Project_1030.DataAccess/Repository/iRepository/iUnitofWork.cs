using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom_Project_1030.DataAccess.Repository.iRepository
{
   public interface iUnitofWork
    {
        iCategoryRepository category { get; }
        iShoppingCartRepository shoppingCart { get; }
        iCoverTypeRepository covertype { get; }
        iProductRepository product { get; }
        iCompanyRepository company { get; }
        iApplicationUserRepository ApplicationUser { get; }
        iOrderHeaderRepository OrderHeader { get; }
        iOrderDetailsRepository OrderDetails { get; }
        ISP_CALL SP_CALL { get; }
        void Save();
    }
}
