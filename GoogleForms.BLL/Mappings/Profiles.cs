using AutoMapper;
using GoogleForms.DTOs;
using GoogleForms.Entities;

namespace GoogleForms.BLL.Mappings
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<FormCreateDto, Form>().ReverseMap();
            CreateMap<FormUpdateDto, Form>().ReverseMap();
            CreateMap<FormListDto, Form>().ReverseMap();

            CreateMap<QuestionCreateDto, Question>().ReverseMap();
            CreateMap<QuestionUpdateDto, Question>().ReverseMap();
            CreateMap<QuestionListDto, Question>().ReverseMap();
            CreateMap<QuestionListDto, QuestionUpdateDto>().ReverseMap();

            CreateMap<AnswerCreateDto, Answer>().ReverseMap();
            CreateMap<AnswerUpdateDto, Answer>().ReverseMap();
            CreateMap<AnswerListDto, Answer>().ReverseMap();
            CreateMap<AnswerListDto, AnswerUpdateDto>().ReverseMap();

            CreateMap<AnswerCreateDto, UserAnswer>().ReverseMap();
            CreateMap<AnswerUpdateDto, UserAnswer>().ReverseMap();
            CreateMap<AnswerListDto, UserAnswer>().ReverseMap();

            

        }

    }
}
