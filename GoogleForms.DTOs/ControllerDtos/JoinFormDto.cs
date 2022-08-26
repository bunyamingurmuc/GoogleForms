using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleForms.DTOs.ControllerDtos
{
    public class JoinFormDto
    {
        public QuestionListDto MainQuestion { get; set; }
        public List<QuestionListDto> Questions { get; set; }
    }
}
