using GoogleForms.Common.Enums;
using GoogleForms.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleForms.Entities
{
    public class Answer:BaseEntity
    {
        public int QuestionId { get; set; }
        public Question Question{ get; set; }
        public string Description { get; set; }
        public AnswerType answerType{ get; set; }
    }
}
