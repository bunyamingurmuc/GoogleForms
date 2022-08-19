using GoogleForms.Common;
using GoogleForms.DTOs;
using GoogleForms.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleForms.BLL.Interfaces
{
    public interface IQuestionService: IService<QuestionCreateDto, QuestionUpdateDto,QuestionListDto,Question>
    {
        public Task<IResponse<QuestionListDto>> AnalyzeQuestion(int id);
    }
}
