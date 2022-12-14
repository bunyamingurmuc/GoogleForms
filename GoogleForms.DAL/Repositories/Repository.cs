using GoogleForms.DAL.Context;
using GoogleForms.DAL.Interfaces;
using GoogleForms.Entities.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GoogleForms.DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly GoogleFormsContext _context;

        public Repository(GoogleFormsContext context)
        {
            _context = context;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter)
        {
            return await _context.Set<T>().Where(filter).ToListAsync();
        }



        public async Task<T?> FindAsync(object id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T?> GetByFilterAsycn(Expression<Func<T, bool>> filter, bool asNoTracking = false)
        {
            return !asNoTracking
                ? await _context.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter)
                : await _context.Set<T>().SingleOrDefaultAsync(filter);
        }

        public async Task<IQueryable<T>> GetQuery()
        {
            var data = await _context.Set<T>().ToListAsync();
            var quarabled = data.AsQueryable();
            return _context.Set<T>().AsQueryable();
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public void Update(T entity, T unchanged)
        {
            _context.Entry(unchanged).CurrentValues.SetValues(entity);
        }
    }
}
