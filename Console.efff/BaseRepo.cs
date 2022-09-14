using console.efff.Models;
using Rrep.Core.InterFaces;
using System.Linq;
using System.Linq.Expressions;

namespace console.efff
{
    public class BaseRepo<T> : IRepo<T> where T : class
    {
        AppDbContext _db;
        public BaseRepo()
        {
              _db = new AppDbContext();
        }

        public bool Add(T Entity)
        {       
            _db.Set<T>().Add(Entity);
            _db.SaveChanges();  
            return true;
        }

        public bool Delete(int id)
        {
            _db.Set<T>().Remove(_db.Set<T>().Find(id));
            _db.SaveChanges();
            return true;
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();

        }

        public T GetById(Expression<Func<T, bool>> predicate)
        {
         return   _db.Set<T>().Where(predicate).FirstOrDefault();
        }

        public bool Update(T Entity)
        {
            throw new NotImplementedException();
        }
    }
}