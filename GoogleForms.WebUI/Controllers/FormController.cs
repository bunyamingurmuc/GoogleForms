using FluentValidation.AspNetCore;
using GoogleForms.BLL.Interfaces;
using GoogleForms.BLL.ValidationRules;
using GoogleForms.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace GoogleForms.WebUI.Controller2
{
    public class FormController : Controller
    {
        IFormService _formService;
        IQuestionService _questionService;
        IAnswerService _answerService;

        public FormController(IFormService formService, IQuestionService questionService, IAnswerService answerService)
        {
            _formService = formService;
            _questionService = questionService;
            _answerService = answerService;
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
            FormCreateDtoValidator validationRules = new FormCreateDtoValidator();
            if (!ModelState.IsValid)
            {
                var messages = ModelState.ToList();
                return View(dto);
            }

            var form = await _formService.CreateAsync(dto);

            return RedirectToAction("QuestionCreate");
        }
        public async Task<IActionResult> QuestionCreate()
        {
            return View();
        }

    }
}
