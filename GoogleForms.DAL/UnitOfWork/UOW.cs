using GoogleForms.DAL.Context;
using GoogleForms.DAL.Interfaces;
using GoogleForms.DAL.Repositories;
using GoogleForms.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleForms.DAL.UnitOfWork
{
    public class UOW : IUOW
    {
        private readonly GoogleFormsContext _context;

        public UOW(GoogleFormsContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(_context);
        }

        public async Task SaveChangesAsycn()
        {
            await _context.SaveChangesAsync();
        }
    }
}
