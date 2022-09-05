using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GoogleForms.DTOs
{
    public class JoinFormDto
    {
        public List<QuestionListDto> Questions { get; set; }
        public List<UserAnswerCreateDto> UserAnswers { get; set; }
        //public List<AnswerListDto> CheckBoxAnswers  { get; set; }
        //public int Skip { get; set; } = 0;

        //public QuestionListDto MainQuestion { get; set; }
        //public List<QuestionListDto> Questions { get; set; }
        //public bool? IsAnswered { get; set; }
    }
}
