using GoogleForms.DTOs.Interfaces;
using GoogleForms.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleForms.BLL.Interfaces
{
    public interface IAppRoleService
    {
        Task<List<AppRole>> GetAllAsync();
        Task<AppRole> GetByIdAsync(int id);
        Task<AppRole> CreateAsync(AppRole entity);
        Task UpdateAsync(AppRole entity);
        Task RemoveAsync(int id);

    }
}
