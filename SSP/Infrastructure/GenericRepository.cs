using Microsoft.EntityFrameworkCore;
using SSP.PayeModelII;
using System.Collections.Generic;
using System.Linq.Expressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SSP.Infrastructure
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
       // IQueryable<T> GetMany(Expression<Func<T, bool>> where);
        T GetById(int id);
        IEnumerable<T> GetById(string id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(int id);

        //IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
        void Save();
    }
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private PayeeContext _context = null;
        private DbSet<T> table = null;
        public GenericRepository()
        {
            this._context = new PayeeContext();
            table = _context.Set<T>();
        }
        public GenericRepository(PayeeContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T GetById(int id)
        {
            return table.Find(id);
        }
        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public IEnumerable<T> GetById(string id)
        {
            //  return table.Where(x => getKey(x).Contains(id)).ToList();

            return (IEnumerable<T>)table;
        }
        //public IQueryable<T> GetMany(Expression<Func<T, bool>> where)
        //{
        //    //  return table.Where(x => getKey(x).Contains(id)).ToList();

        //    return table.AsNoTracking().Where(where);
        //}

        //public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
        //      !trackChanges ?
        //          _context.Set<T>()
        //          .Where(expression)
        //          .AsNoTracking() : _context.Set<T>().Where(expression);
    }
}