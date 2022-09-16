using AutoMapper;
using FluentValidation;
using GoogleForms.BLL.Interfaces;
using GoogleForms.Common.Enums;
using GoogleForms.DAL.UnitOfWork;
using GoogleForms.DTOs;
using GoogleForms.Entities;

namespace GoogleForms.BLL.Services
{
    public class AnswerService : Service<AnswerCreateDto, AnswerUpdateDto, AnswerListDto, Answer>, IAnswerService
    {

        public readonly IUOW _uow;
        public readonly IMapper _mapper;
        public readonly IValidator<AnswerCreateDto> _createDtoValidator;
        public readonly IValidator<AnswerUpdateDto> _updateDtoValidator;

        public AnswerService(IUOW uow, IMapper mapper, IValidator<AnswerCreateDto> createDtoValidator, IValidator<AnswerUpdateDto> updateDtoValidator):base(mapper,createDtoValidator,updateDtoValidator, uow)
        {
            _uow = uow;
            _mapper = mapper;
            _createDtoValidator = createDtoValidator;
            _updateDtoValidator = updateDtoValidator;
        }

       


        public async Task<AnswerType> FindAnswerType(string description)
        {
          
            
            var answerDscription = description;
            int n;
            bool isNumeric = int.TryParse(answerDscription, out n);
            if (isNumeric==true)
            {
               return Common.Enums.AnswerType.number;
            }
            else
            {
               return Common.Enums.AnswerType.text;
            }



        }

        public  async Task<bool> FindIsItUnique(string description, int questionId)
        {
            var allAnswers = await _uow.GetRepository<Answer>().GetAllAsync();
            var answers= allAnswers.Where(a => a.QuestionId == questionId).ToList();
            var isItUnique = true;
            if (answers!=null)
            {
                foreach (var answer in answers)
                {
                    if (answer.Description.Trim()==description.Trim())
                    {
                        isItUnique=false;
                    }
                }
            }
            return isItUnique;
            
        }
    }
}
