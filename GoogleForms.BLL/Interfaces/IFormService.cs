using GoogleForms.DTOs;
using GoogleForms.Entities;

namespace GoogleForms.BLL.Interfaces
{
    public interface IFormService:IService<FormCreateDto,FormUpdateDto,FormListDto,Form>
    {
        Task<FormCreateDto> SoruEkle(FormCreateDto dto);
        Task<List<FormListDto>> SorulariCevaplariIleGetir();



    }
}
