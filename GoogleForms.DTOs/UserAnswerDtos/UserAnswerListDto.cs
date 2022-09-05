using GoogleForms.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleForms.DTOs
{
    public class UserAnswerListDto
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public QuestionListDto Question { get; set; }
        public string Description { get; set; }
        public AnswerType answerType { get; set; }
        public int NumberOfChoose { get; set; }

    }
}
