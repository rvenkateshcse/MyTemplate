using System;
using System.Linq;

namespace WebAPITemplate
{
    public class DBOperations<T> where T : BaseEntity
    {
        private DataBaseContext _context;

        public void Insert(T Entity)
        {
            _context.Set<T>().Add(Entity);
            _context.SaveChanges();
        }

        public T Get(Guid guid)
        {
            return _context.Set<T>().FirstOrDefault(x => x.guid == guid);
        }

        public object Get()
        {
            return _context.Set<T>().ToList();
        }

        public void Update(T Entity)
        {
            _context.Set<T>().Update(Entity);
            _context.SaveChanges();
        }
    }
}