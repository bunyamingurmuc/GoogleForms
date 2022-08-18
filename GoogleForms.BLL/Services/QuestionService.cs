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
    public class QuestionService : Service<QuestionCreateDto, QuestionUpdateDto, QuestionListDto, Question>, IQuestionService
    {
        public QuestionService(IMapper mapper, IValidator<QuestionCreateDto> createDtoValidator, IValidator<QuestionUpdateDto> updateDtoValidator, IUOW uow) : base(mapper, createDtoValidator, updateDtoValidator, uow)
        {
        }
    }
}
