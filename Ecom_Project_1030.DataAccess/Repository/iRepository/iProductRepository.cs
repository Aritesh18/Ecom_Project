using Ecom_Project_1030.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom_Project_1030.DataAccess.Repository.iRepository
{
  public  interface iProductRepository:iRepository<Product>
    {
        void Update(Product product);
    }
}
