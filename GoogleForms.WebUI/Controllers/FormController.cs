using FluentValidation;
using FluentValidation.AspNetCore;
using GoogleForms.BLL.Extensions;
using GoogleForms.BLL.Interfaces;
using GoogleForms.BLL.ValidationRules;
using GoogleForms.DTOs;
using GoogleForms.DTOs.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GoogleForms.WebUI.Controller2
{
    public class FormController : Controller
    {
        IFormService _formService;
        IQuestionService _questionService;
        IAnswerService _answerService;
        private readonly IValidator<FormCreateDto> _fcreateDtoValidator;
        private readonly IValidator<QuestionCreateDto> _qcreateDtoValidator;
        private readonly IValidator<AnswerCreateDto> _acreateDtoValidator;

        public FormController(IFormService formService, IQuestionService questionService, IAnswerService answerService, IValidator<FormCreateDto> fcreateDtoValidator, IValidator<QuestionCreateDto> qcreateDtoValidator, IValidator<AnswerCreateDto> acreateDtoValidator)
        {
            _formService = formService;
            _questionService = questionService;
            _answerService = answerService;
            _fcreateDtoValidator = fcreateDtoValidator;
            _qcreateDtoValidator = qcreateDtoValidator;
            _acreateDtoValidator = acreateDtoValidator;
        }

        public async Task<IActionResult> Index()
        {
            var forms = await _formService.GetAllAsync();

            return View(forms);
        }
        public async Task<IActionResult> FormCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> FormCreate(FormCreateDto dto)
        {
            
           var result= _fcreateDtoValidator.Validate(dto);
            if (!result.IsValid)
            {
                ModelState.Clear();
                foreach (var error in result.ConvertToCustomValidationError())
                {
                    
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return View(dto);
            }
            var form = await _formService.CreateAsync(dto);
            var forms = await _formService.GetAllAsync();
           var formListDto=forms.Where(i=>i.FormTitle==form.FormTitle&&i.FormDescription==form.FormDescription).FirstOrDefault();

         //   ViewBag.id=formId;
            return RedirectToAction("QuestionCreate",formListDto);
        }
        public async Task<IActionResult> QuestionCreate(FormListDto formListDto)
        {
            QuestionCreateController dto = new();
            dto.FormListDto = formListDto;
            if (formListDto.Questions!=null)
            {
                dto.questionListDtos = formListDto.Questions;
            }
           
            return View(dto);
        }
        [HttpPost]
        public async Task<IActionResult> QuestionCreate(QuestionCreateDto dto)
        {
            return View();
        }
    }
}
