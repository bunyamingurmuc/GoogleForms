using GoogleForms.Common;
using GoogleForms.Common.Enums;
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
        Task<AnswerType> FindAnswerType(string description);
        Task<bool> FindIsItUnique(string description, int questionId);

    }
}
