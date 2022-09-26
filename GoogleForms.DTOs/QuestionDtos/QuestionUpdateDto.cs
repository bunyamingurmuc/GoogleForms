using GoogleForms.Common.Enums;
using GoogleForms.DTOs.Interfaces;

namespace GoogleForms.DTOs
{
    public class QuestionUpdateDto : IUpdateDto
    {
        public QuestionUpdateDto()
        {
            UserAnswers = new List<AnswerListDto>();
        }
        public int Id { get; set; }
        public string QuestionTitle { get; set; }
        public bool IsUnique { get; set; } = false;
        public QuestionType QuestionType { get; set; }
        public int FormId { get; set; }
        public FormUpdateDto Form { get; set; }
        public List<AnswerUpdateDto>? Answers { get; set; }
        public List<AnswerListDto>? UserAnswers { get; set; }

        public int? RelatedQuestionId { get; set; }


        public double? AverageAnswersValue { get; set; }
        public double? AverageOfAllAnswers { get; set; }
        public double? MinAnsweresValue { get; set; }
        public double? MaxAnsweresValue { get; set; }
        public double? CorrectAnswerAverage { get; set; }
        public double? WrongAnswerAverage { get; set; }

        public int NumberOfAnswers { get; set; } = 0;
        public double? MinChoiceAnsweresValue { get; set; }
        public double? MaxChoiceAnsweresValue { get; set; }
        public bool IsAnswered { get; set; }
        public int? OpertionQuestion1Id { get; set; }
        public int? OpertionQuestion2Id { get; set; }
        public OperationType? OperationType { get; set; }



    }
}
