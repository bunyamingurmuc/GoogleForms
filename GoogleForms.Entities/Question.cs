﻿using GoogleForms.Common.Enums;
using GoogleForms.Entities.Interface;

namespace GoogleForms.Entities
{
    public class Question : BaseEntity
    {
        public Question()
        {
            UserAnswers = new List<UserAnswer>();
        }
        public string QuestionTitle { get; set; }
        public bool IsRequired { get; set; }
        public QuestionType QuestionType{ get; set; }
        public int FormId { get; set; }
        public Form Form { get; set; }
        public List<Answer> Answers { get; set; }
        public List<UserAnswer> UserAnswers { get; set; }

        public double? AverageAnswersValue { get; set; }
        public double? AverageOfAllAnswers { get; set; }
        public double? MinAnsweresValue { get; set; }
        public double? MaxAnsweresValue { get; set; }
        public double? CorrectAnswerAverage { get; set; }
        public double? WrongAnswerAverage { get; set; }

        public int NumberOfAnswers { get; set; }
        public double? MinChoiceAnsweresValue { get; set; }
        public double? MaxChoiceAnsweresValue { get; set; }
        public bool IsAnswered { get; set; }


    }
 
}
