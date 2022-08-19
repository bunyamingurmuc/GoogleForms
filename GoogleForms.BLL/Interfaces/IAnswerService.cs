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
    public interface IAnswerService:IService< AnswerCreateDto, AnswerUpdateDto, AnswerListDto,Answer >
    {
        Task<AnswerListDto> TakeTrueAnswer(int id);
        Task<AnswerListDto> SetAnswerType(int id);

    }
}
