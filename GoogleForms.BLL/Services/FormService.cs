using AutoMapper;
using FluentValidation;
using GoogleForms.BLL.Interfaces;
using GoogleForms.DAL.UnitOfWork;
using GoogleForms.DTOs;
using GoogleForms.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoogleForms.BLL.Services
{
    public class FormService : Service<FormCreateDto, FormUpdateDto, FormListDto, Form>, IFormService
    {
        public readonly IUOW _uow;
        public readonly IMapper _mapper;
        public readonly IValidator<FormCreateDto> _createDtoValidator;
        public readonly IValidator<FormUpdateDto> _updateDtoValidator;
        public FormService(IMapper mapper, IValidator<FormCreateDto> createDtoValidator, IValidator<FormUpdateDto> updateDtoValidator, IUOW uow) : base(mapper, createDtoValidator, updateDtoValidator, uow)
        {
            _mapper = mapper;
            _createDtoValidator = createDtoValidator;
            _updateDtoValidator = updateDtoValidator;
            _uow = uow;
        }

        public async Task<FormCreateDto> SoruEkle(FormCreateDto dto)
        {
            var entity= _mapper.Map<Form>(dto);
           await _uow.GetRepository<Form>().CreateAsync(entity);
            await _uow.SaveChangesAsycn();
            return dto;
        }

        public async Task<List<FormListDto>> SorulariCevaplariIleGetir()
        {
            var question =await  _uow.GetRepository<Form>().GetQuery();
            var questionList = await question
                //.Include(x => x.Questions
                //        .Select(i => i.Answers))
                .ToListAsync();
            var mapped= _mapper.Map<List<FormListDto>>(questionList);
            return mapped;

        }
    }
}
