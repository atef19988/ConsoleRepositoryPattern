using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rrep.Core.InterFaces
{
    public interface IRepo<T> where T : class
    {
        bool Add(T Entity);
        bool Update(T Entity); 
        bool Delete(int id); 
        List<T> GetAll();

        T GetById(Expression<Func<T, bool>> predicate); 

    }
}
