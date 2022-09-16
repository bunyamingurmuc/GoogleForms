using GoogleForms.DTOs;
using GoogleForms.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GoogleForms.BLL.Interfaces
{
    public interface IAppUserService
    {
        Task<List<AppUser>> GetAllAsync();
        Task<AppUser> GetByIdAsync(int id);
        Task<AppUser> CreateAsync(AppUser entity);
        Task<AppUser> CreateAsync(AppUser entity,string password);
        Task UpdateAsync(AppUser entity);
        Task RemoveAsync(int id);

    }
}
