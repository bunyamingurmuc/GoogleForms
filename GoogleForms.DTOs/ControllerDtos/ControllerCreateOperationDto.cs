using GoogleForms.Common.Enums;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;

namespace GoogleForms.DTOs
{
    public class ControllerCreateOperationDto
    {
        public List<QuestionListDto> questionListDtos { get; set; }
        public int SelectedQuestionId1 { get; set; }
        public int SelectedQuestionId2 { get; set; }
        public int MainQuesitonId { get; set; }
        public OperationType operandType { get; set; }
    }
}

