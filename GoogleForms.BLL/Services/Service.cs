using AutoMapper;
using FluentValidation;
using GoogleForms.BLL.Interfaces;
using GoogleForms.DAL.UnitOfWork;
using GoogleForms.DTOs.Interfaces;
using GoogleForms.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleForms.BLL.Services
{
    public class Service<CreateDto, UpdateDto, ListDto, T> : IService<CreateDto, UpdateDto, ListDto, T>
     where CreateDto : class, IDto, new()
     where ListDto : class, IDto, new()
     where UpdateDto : class, IUpdateDto, new()
     where T : BaseEntity
    {
        private readonly IMapper _mapper;
        private readonly IValidator<CreateDto> _createDtoValidator;
        private readonly IValidator<UpdateDto> _updateDtoValidator;
        private readonly IUOW _uow;

        public Service(IMapper mapper, IValidator<CreateDto> createDtoValidator, IValidator<UpdateDto> updateDtoValidator, IUOW uow)
        {
            _mapper = mapper;
            _createDtoValidator = createDtoValidator;
            _updateDtoValidator = updateDtoValidator;
            _uow = uow;
        }

        public async Task<List<ListDto>> GetAllAsync()
        {
            var data = await _uow.GetRepository<T>().GetAllAsync();
            var dto = _mapper.Map<List<ListDto>>(data);
            return dto;
        }

        public async Task<IDto> GetByIdAsync<IDto>(int id)
        {
            var data = await _uow.GetRepository<T>().GetByFilterAsycn(x => x.Id == id);
            
            var dto = _mapper.Map<IDto>(data);
            return dto;
        }

        public async Task<CreateDto> CreateAsync(CreateDto dto)
        {
            var result = _createDtoValidator.Validate(dto);
            if (result.IsValid)
            {
                var createdEntity = _mapper.Map<T>(dto);
                await _uow.GetRepository<T>().CreateAsync(createdEntity);
                await _uow.SaveChangesAsycn();
            }
            return dto;


        }

        public async Task<UpdateDto> UpdateAsync(UpdateDto dto)
        {
            var result = _updateDtoValidator.Validate(dto);
            if (result.IsValid)
            {
                var unchangedData = await _uow.GetRepository<T>().FindAsync(dto.Id);
              

                var entity = _mapper.Map<T>(dto);
                _uow.GetRepository<T>().Update(entity, unchangedData);
                await _uow.SaveChangesAsycn();
                return dto;
            }
            return dto;
        }

        public async Task RemoveAsync(int id)
        {
            var data = await _uow.GetRepository<T>().FindAsync(id);
            _uow.GetRepository<T>().Remove(data);
            await _uow.SaveChangesAsycn();
            
        }
    }
}
