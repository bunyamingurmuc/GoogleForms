using AutoMapper;
using FluentValidation;
using GoogleForms.BLL.Interfaces;
using GoogleForms.DAL.UnitOfWork;
using GoogleForms.DTOs;
using GoogleForms.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleForms.BLL.Services
{
    public class AnswerService : Service<AnswerCreateDto, AnswerUpdateDto, AnswerListDto, Answer>, IAnswerService
    {
        public AnswerService(IMapper mapper, IValidator<AnswerCreateDto> createDtoValidator, IValidator<AnswerUpdateDto> updateDtoValidator, IUOW uow) : base(mapper, createDtoValidator, updateDtoValidator, uow)
        {
        }
    }
}
