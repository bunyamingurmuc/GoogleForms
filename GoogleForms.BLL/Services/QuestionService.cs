using AutoMapper;
using Buyfilet.Common;
using FluentValidation;
using GoogleForms.BLL.Interfaces;
using GoogleForms.Common;
using GoogleForms.DAL.UnitOfWork;
using GoogleForms.DTOs;
using GoogleForms.Entities;

namespace GoogleForms.BLL.Services
{
    public class QuestionService : Service<QuestionCreateDto, QuestionUpdateDto, QuestionListDto, Question>, IQuestionService
    {
        public readonly IMapper _mapper;
        public readonly IValidator<QuestionCreateDto> _createDtoValidator;
        public readonly IValidator<QuestionUpdateDto> _updateDtoValidator;
        public readonly IUOW _uow;

        public QuestionService(IMapper mapper, IValidator<QuestionCreateDto> createDtoValidator, IValidator<QuestionUpdateDto> updateDtoValidator, IUOW uow) : base(mapper, createDtoValidator, updateDtoValidator, uow)
        {
            _mapper = mapper;
            _createDtoValidator = createDtoValidator;
            _updateDtoValidator = updateDtoValidator;
            _uow = uow;
        }

        public async Task<IResponse<QuestionListDto>> AnalyzeQuestion(int id)
        {
            double avarageValue = 0;
            var minValue = 0;
            var maxValue = 0;
            var correctAnswerAverage = 0;
            var wrongAnswerAverage = 0;
            var minChoiceAnsweresValue= 0;
            var maxChoiceAnsweresValue = 0;
            var values =new List<int>();
            var question = await _uow.GetRepository<Question>().FindAsync(id);
            if (question == null)
            {
                return new Response<QuestionListDto>(Buyfilet.Common.Enums.ResponseType.NotFound, $"{id} ye sahip cevap bulunamadı");
            }
            else
            {
                if (question.QuestionType == Common.Enums.QuestionType.CoktanSecmeli)
                {
                    maxChoiceAnsweresValue = (question.Answers.Max(i => i.NumberOfChoose)) / (question.NumberOfAnswers);
                    correctAnswerAverage = ((question.Answers.Where(i => i.IsItTrueAnswer == true).FirstOrDefault().NumberOfChoose) / (question.NumberOfAnswers) * 100);
                    wrongAnswerAverage = (1 - ((question.Answers.Where(i => i.IsItTrueAnswer == true).FirstOrDefault().NumberOfChoose) / (question.NumberOfAnswers)) * 100);
                    minChoiceAnsweresValue=question.Answers.Min(i => i.NumberOfChoose);
                }
                else if (question.QuestionType == Common.Enums.QuestionType.KisaYanit && question.Answers.All(i => i.answerType == Common.Enums.AnswerType.number))
                {
                    foreach (var answer in question.Answers)
                    {
                        var value = int.Parse(answer.Description);
                        values.Add(value); 
                    }
                    minValue=values.Min();
                    maxValue=values.Max();
                    avarageValue = values.Average();
                }
                question.MaxChoiceAnsweresValue = maxChoiceAnsweresValue;
                question.MinChoiceAnsweresValue = minChoiceAnsweresValue;
                question.CorrectAnswerAverage = correctAnswerAverage;
                question.WrongAnswerAverage = wrongAnswerAverage;
                question.MinAnsweresValue = minValue;
                question.MaxAnsweresValue=maxValue;
                question.AverageAnswersValue = avarageValue;
                await _uow.SaveChangesAsycn();
                return new Response<QuestionListDto>(Buyfilet.Common.Enums.ResponseType.Success, _mapper.Map<QuestionListDto>(question));
            }
        }
    }
}
