using GoogleForms.DTOs.Interfaces;
using GoogleForms.Entities.Interface;

namespace GoogleForms.BLL.Interfaces
{
    public interface IService<CreateDto, UpdateDto, ListDto, T>
    where CreateDto : class, IDto, new()
    where UpdateDto : class, IUpdateDto, new()
    where ListDto : class, IDto, new()
    where T : BaseEntity
    {
        Task<List<ListDto>> GetAllAsync();
        Task<IDto> GetByIdAsync<IDto>(int id);
        Task<CreateDto> CreateAsync(CreateDto dto);
        Task<UpdateDto> UpdateAsync(UpdateDto dto);
        Task RemoveAsync(int id);
    }
}
