using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GoogleForms.DTOs
{
    public class ControllerSelectEntityDto
    {
        public ControllerSelectEntityDto()
        {
            forms = new List<FormListDto>();
            questions = new List<QuestionListDto>();
        }
        public List<FormListDto> forms { get; set; }
        public int FormId { get; set; }
        public List<QuestionListDto> questions { get; set; }
        public int QuestionId { get; set; }
        public int mainQuesionId { get; set; }
    }
}
