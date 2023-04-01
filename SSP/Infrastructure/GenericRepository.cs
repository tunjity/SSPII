using Microsoft.EntityFrameworkCore;
using SSP.PayeModel;
using System.Collections.Generic;
using System.Linq.Expressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SSP.Infrastructure
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        IEnumerable<T> GetById(string id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(int id);
        void Save();
    }
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private PinscherSpikeContext _context = null;
        private DbSet<T> table = null;
        public GenericRepository()
        {
            this._context = new PinscherSpikeContext();
            table = _context.Set<T>();
        }
        public GenericRepository(PinscherSpikeContext _context)
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
            //var res = table.Where(x => getKey(x).Contains(id)).ToList();

            return (IEnumerable<T>)table.Find(id);
        }
        public List<T> LikeSearch<T>(List<T> list, Func<T, string> getKey, string searchString)
        {
            return list.Where(x => getKey(x).Contains(searchString)).ToList();
        }
    }
}