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
    public class OrderDetailsRepository : Repository<OrderDetails>, iOrderDetailsRepository
    {
        private readonly ApplicationDbContext _context;
        public OrderDetailsRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public void Update(OrderDetails orderDetails)
        {
            _context.OrderDetails.Update(orderDetails);
            
        }
    }
}
