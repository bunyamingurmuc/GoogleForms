using FluentValidation;
using GoogleForms.BLL.Extensions;
using GoogleForms.BLL.Interfaces;
using GoogleForms.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public FormListDto globalFormListDto = new FormListDto();
      //  public int formGlobalId;

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
        public async Task<IActionResult> FormView(FormListDto dto)
        {
            return View(dto);
        }
        public async Task<IActionResult> FormCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> FormCreate(FormCreateDto dto)
        {

            var result = _fcreateDtoValidator.Validate(dto);
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
            var formListDto = forms.Where(i => i.FormTitle == form.FormTitle && i.FormDescription == form.FormDescription).FirstOrDefault();
            globalFormListDto.Id = formListDto.Id;
            globalFormListDto.FormTitle = form.FormTitle;
            globalFormListDto.FormDescription = form.FormDescription;            
            return RedirectToAction("FormView", globalFormListDto);
        }

        
        public async Task<IActionResult> QuestionCreate(int id)
        {
          
          QuestionCreateDto dto = new QuestionCreateDto();
            dto.FormId = id;
            return View(dto); 
        }
        [HttpPost]
        public async Task<IActionResult> QuestionCreate(QuestionCreateDto questionCreateDto)

        {

            var result = _qcreateDtoValidator.Validate(questionCreateDto);
            if (!result.IsValid)
            {
                ModelState.Clear();
                foreach (var error in result.ConvertToCustomValidationError())
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return View(questionCreateDto);
            }

            await _questionService.CreateAsync(questionCreateDto);

            var formlists = await _formService.GetAllAsync();
            var formListDto = formlists.FirstOrDefault(i => i.Id == questionCreateDto.FormId);
          
            return View("FormView", formListDto);
        }
        public async Task<IActionResult> AnswerCreate(int id)
        {
           
            AnswerCreateDto dto = new AnswerCreateDto();
            dto.QuestionId = id;
            return View(dto);
        }
        [HttpPost]
        public async Task<IActionResult> AnswerCreate(AnswerCreateDto dto)
        {
            var result = _acreateDtoValidator.Validate(dto);
            if (!result.IsValid)
            {
                ModelState.Clear();
                foreach (var error in result.ConvertToCustomValidationError())
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return View(dto);
            }
            await _answerService.CreateAsync(dto);
            var questions = await _questionService.GetAllAsync();
            var questionListDto = questions.FirstOrDefault(i => i.Id == dto.QuestionId);
            var formLists= await _formService.GetAllAsync();
            var formListDto = formLists.FirstOrDefault(i => i.Id == questionListDto.FormId);
            return View("FormView", formListDto);
        }

        public async Task<IActionResult> JoinForm(int id)
        {
            var formListDto= await _formService.GetByIdAsync<FormListDto>(id);
            var allAnswers= await _answerService.GetAllAsync();
            var answersQuary1 =allAnswers.AsQueryable();
            var answersQuary2 = answersQuary1.Include(x => x.Question);
            var answers = answersQuary2.Include(x => x.Question).Where(i=>i.Question.FormId==id).ToList();
            return View(answers);
        }
        [HttpPost]
        public async Task<IActionResult> JoinForm(AnswerListDto answerListDto)
        {

            return View();
        }
        
    }
}
