using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ecom_Project_1030.DataAccess.Repository.iRepository
{
    public interface iRepository<T> where T : class
    {
        void Add(T entity);
        void Remove(T entity);
        void Remove(int id);  //Delete through Id
        void RemoveRange(IEnumerable<T> entity);  //Delete all Records
        T Get(int id); //find
        IEnumerable<T> GetAll(
           Expression<Func<T, bool>> filter = null,
           Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
           string includeProperties = null  //category,coverType
            );
        T FirstorDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null //category,coverType
             );

    }
}
