using GoogleForms.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleForms.DTOs
{
    public class QuestionCreateController
    {
        public FormListDto? FormListDto { get; set; }
        public List<QuestionListDto>? questionListDtos{ get; set; }
        public QuestionCreateDto? questionCreateDto{ get; set; }
       
    }
}
