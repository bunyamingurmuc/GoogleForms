using AutoMapper;
using FluentValidation;
using GoogleForms.BLL.Interfaces;
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

       

        public async Task<AnswerListDto> TakeTrueAnswer(int id)
        {
                var entity= await _uow.GetRepository<Answer>().FindAsync(id);
                entity.IsItTrueAnswer = true;
                await _uow.SaveChangesAsycn();
                return _mapper.Map<AnswerListDto>(entity);
        }
        public async Task<AnswerListDto> SetAnswerType(int id)
        {
          
            var answer = await _uow.GetRepository<Answer>().FindAsync(id);
            var answerDscription = answer.Description;
            int n;
            bool isNumeric = int.TryParse(answerDscription, out n);
            if (isNumeric==true)
            {
                answer.answerType = Common.Enums.AnswerType.number;
            }
            else
            {
                answer.answerType = Common.Enums.AnswerType.text;
            }
            return _mapper.Map<AnswerListDto>(answer);
        }
    }
}
