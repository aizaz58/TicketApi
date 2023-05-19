using Microsoft.EntityFrameworkCore;
using TicketApi.Data;
using TicketApi.Interfaces;

namespace TicketApi.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            this._context = context;
            this._dbSet=_context.Set<T>();  
        }
        public void Add(T entity)
        {
          _dbSet.Add(entity);   
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int? id)
        {
           return _dbSet.Find(id);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
