using GoogleForms.DAL.Interfaces;
using GoogleForms.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleForms.DAL.UnitOfWork
{
    public interface IUOW
    {
        IRepository<T> GetRepository<T>() where T : class;
        Task SaveChangesAsycn();
    }
}
