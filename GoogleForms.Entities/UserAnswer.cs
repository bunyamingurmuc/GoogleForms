using GoogleForms.Common.Enums;
using GoogleForms.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleForms.Entities
{
    public class UserAnswer:BaseEntity
    {
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public string Description { get; set; }
        public AnswerType answerType { get; set; }
        public bool IsItTrueAnswer { get; set; } = false;
        public int NumberOfChoose { get; set; }
        public bool IsSelected { get; set; } = false;
    }
}
