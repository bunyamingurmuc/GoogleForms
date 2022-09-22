using AutoMapper;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using FluentValidation;
using GoogleForms.BLL.Extensions;
using GoogleForms.BLL.Interfaces;
using GoogleForms.DTOs;
using GoogleForms.DTOs.ControllerDtos;
using GoogleForms.Entities;
using GoogleForms.Entities.UserEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Office.Interop.Excel;
using System.Linq;
using System.Net;
using System.Transactions;
using GoogleForms.Common.Enums;

namespace GoogleForms.WebUI.Controller2
{
    public class FormController : Controller
    {
        IFormService _formService;
        IQuestionService _questionService;
        IAnswerService _answerService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IValidator<FormCreateDto> _fcreateDtoValidator;
        private readonly IValidator<QuestionCreateDto> _qcreateDtoValidator;
        private readonly IValidator<AnswerCreateDto> _acreateDtoValidator;
        private readonly IValidator<UserAnswerCreateDto> _uacreateDtoValidator;
        public FormListDto globalFormListDto = new FormListDto();
        public readonly IMapper _mapper;
        //  public int formGlobalId;

        public FormController(IFormService formService, IQuestionService questionService, IAnswerService answerService, IValidator<FormCreateDto> fcreateDtoValidator, IValidator<QuestionCreateDto> qcreateDtoValidator, IValidator<AnswerCreateDto> acreateDtoValidator, IMapper mapper, IValidator<UserAnswerCreateDto> uacreateDtoValidator = null, UserManager<AppUser> userManager = null)
        {
            _formService = formService;
            _questionService = questionService;
            _answerService = answerService;
            _fcreateDtoValidator = fcreateDtoValidator;
            _qcreateDtoValidator = qcreateDtoValidator;
            _acreateDtoValidator = acreateDtoValidator;
            _mapper = mapper;
            _uacreateDtoValidator = uacreateDtoValidator;
            _userManager = userManager;
        }
        public async Task<IActionResult> AccessDenied()
        {
            return View();
        }
        public async Task<IActionResult> Home()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var forms = await _formService.GetQuestionWithAnswersAndUsers();

            var userforms = _mapper.Map<List<FormListDto>>(user.Forms);
            var listAdd = new List<FormListDto>();

            foreach (var form in forms)
            {
                foreach (var userform in userforms)
                {
                    if (form.Id == userform.Id)
                    {
                        listAdd.Add(form);
                    }
                }
            }
            if (user.Forms != null)
            {
                return View(listAdd);
            }
            return View();
        }
        public async Task<IActionResult> FormView(int id)
        {
            var dto = await _formService.GetByIdAsync<FormListDto>(id);
            return View(dto);
        }

        public async Task<IActionResult> SelectEntity(int id, ControllerSelectEntityDto? dto)
        {
            var addingEntityQuestion = await _questionService.GetByIdAsync<QuestionListDto>(dto.QuestionId);

            var forms = await _formService.GetQuestionWithAnswersAndUsers();
            if (dto.FormId != 0)
            {
                var selectedForm = forms.FirstOrDefault(form => form.Id == dto.FormId);
                dto.questions = selectedForm.Questions.Where(i => i.QuestionType == Common.Enums.QuestionType.KisaYanit || i.QuestionType == Common.Enums.QuestionType.Paragraf).ToList();
            }
            if (dto.QuestionId != 0)
            {


                var mainquestion = await _questionService.GetByIdAsync<QuestionListDto>(dto.mainQuesionId);
                mainquestion.RelatedQuestionId = dto.QuestionId;
                var test = await _questionService.UpdateAsync(_mapper.Map<QuestionUpdateDto>(addingEntityQuestion));
                foreach (var answer in addingEntityQuestion.Answers)
                {
                    await _answerService.CreateAsync(new AnswerCreateDto()
                    {
                        QuestionId = dto.mainQuesionId,
                        Description = answer.Description,
                        answerType = await _answerService.FindAnswerType(answer.Description),
                    });

                    await _questionService.UpdateAsync(_mapper.Map<QuestionUpdateDto>(mainquestion));
                }

                var form = await _formService.GetByIdAsync<FormListDto>(mainquestion.FormId);

                return View("FormView", form);
            }

            dto.mainQuesionId = id;
            dto.forms = forms;
            return View(dto);
        }
        public async Task<IActionResult> FormCreate()
        {
            return View();
        }

        public async Task<IActionResult> FormDelete(int id)
        {
            await _formService.RemoveAsync(id);
            return RedirectToAction("Index");
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

            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            dto.appUsers.Add(user);
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

        public async Task<IActionResult> QuestionDelete(int id)
        {
                var question=await _questionService.GetByIdAsync<QuestionListDto>(id);
            
            await _questionService.RemoveAsync(id);
            var formListDto = await _formService.GetByIdAsync<FormListDto>(question.FormId);

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
            var formLists = await _formService.GetAllAsync();
            var formListDto = formLists.FirstOrDefault(i => i.Id == questionListDto.FormId);
            return View("FormView", formListDto);
        }

        public async Task<IActionResult> JoinForm(int id)
        {
            var formListDto = await _formService.GetByIdAsync<FormListDto>(id);


            var varlikQuestions = formListDto.Questions.Where(i => i.QuestionType == Common.Enums.QuestionType.VarliktanYükle).ToList();

            foreach (var varlıkquestion in varlikQuestions)
            {
                var varlikparent = await _questionService.GetByIdAsync<QuestionListDto>(varlıkquestion.RelatedQuestionId.Value);
                if (varlıkquestion.Answers.Count() != varlikparent.Answers.Count())
                {

                }
            }
            var allAnswers = await _answerService.GetAllAsync();
            var answers = allAnswers.Where(i => i.Question.FormId == id).ToList();
            JoinFormDto dto = new JoinFormDto();
            dto.Questions = formListDto.Questions;
            List<UserAnswerCreateDto> userAnswerCreateDtos = new List<UserAnswerCreateDto>();
            List<AnswerListDto> checkBoxAnswers = new();




            for (int i = 0; i < formListDto.Questions.Where(i => i.QuestionType == Common.Enums.QuestionType.KisaYanit || i.QuestionType == Common.Enums.QuestionType.Paragraf).Count(); i++)
            {
                userAnswerCreateDtos.Add(new UserAnswerCreateDto() { });
            }
            //for (int i = 0; i < answers.Count(); i++)
            //{
            //    checkBoxAnswers.Add(new AnswerListDto() { });
            //}d
            //dto.CheckBoxAnswers=checkBoxAnswers;
            dto.UserAnswers = userAnswerCreateDtos;
            var orderedquestion = dto.Questions.OrderBy(i => i.Answers.Where(i => i.IsItUserAnswer == false).Count()).ToList();
            dto.Questions.Clear();
            dto.Questions = orderedquestion;

            return View(dto);
        }
        [HttpPost]
        public async Task<IActionResult> JoinForm(JoinFormDto dto)
        {
            var q = await _questionService.GetByIdAsync<QuestionListDto>(dto.Questions[0].Id);
            var formListDto = await _formService.GetByIdAsync<FormListDto>(q.FormId);
            var questions = formListDto.Questions;
            var allquestions = await _questionService.GetAllAsync();

            for (int j = 0; j < dto.Questions.Count(); j++)
            {
                if (dto.Questions[j].QuestionType == Common.Enums.QuestionType.KisaYanit || dto.Questions[j].QuestionType == Common.Enums.QuestionType.Paragraf)
                {




                    if (dto.UserAnswers != null)
                    {


                        var question = await _questionService.GetByIdAsync<QuestionListDto>(dto.UserAnswers[j].QuestionId);
                        var bak = dto.UserAnswers[j];
                        var result = _uacreateDtoValidator.Validate(bak);
                        if (!result.IsValid)
                        {
                            ModelState.Clear();
                            foreach (var error in result.ConvertToCustomValidationError())
                            {
                                ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                            }
                            return View(dto);
                        }
                        if (question.IsUnique == true)
                        {
                            var answers = await _answerService.GetAllAsync();
                            var isItUniqueResult = await _answerService.FindIsItUnique(dto.UserAnswers[j].Description, question.Id);
                            if (isItUniqueResult == false)
                            {
                                ModelState.Clear();
                                ModelState.AddModelError("", "Bu cevap daha önce girildi");
                                return View(dto);
                            }
                        }
                        var findedAnswerType = await _answerService.FindAnswerType(dto.UserAnswers[j].Description);
                        var answerCreateDto = new AnswerCreateDto()
                        {
                            answerType = findedAnswerType,
                            Description = dto.UserAnswers[j].Description,
                            QuestionId = dto.UserAnswers[j].QuestionId,
                            IsItUserAnswer = true,
                        };
                        var relatedquesitons = allquestions.Where(i => i.RelatedQuestionId == dto.Questions[j].Id).ToList();

                        if (relatedquesitons.Count() != 0)
                        {
                            foreach (var relatedquestion in relatedquesitons)
                            {
                                await _answerService.CreateAsync(new AnswerCreateDto
                                {
                                    QuestionId = relatedquestion.Id,
                                    Description = dto.UserAnswers[j].Description

                                });
                            };
                        }

                        var CREATED = await _answerService.CreateAsync(answerCreateDto);


                    }
                }
               
                else
                {

                    var answers = await _answerService.GetAllAsync();

                    foreach (var question in dto.Questions.Where(i => i.QuestionType == Common.Enums.QuestionType.CoktanSecmeli || i.QuestionType == Common.Enums.QuestionType.OnayKutulari))
                    {
                        if (question.QuestionType == Common.Enums.QuestionType.CoktanSecmeli)
                        {
                            if (question.Answers.Where(i => i.IsSelected == true).Count() > 1)
                            {
                                ModelState.Clear();
                                ModelState.AddModelError("", "Coktan seçmeli sorularda en fazla bir seçenek seçebilirsiniz");
                                return View(dto);
                            }

                        }
                        foreach (var answer in question.Answers)
                        {
                            if (answer.IsSelected == true)
                            {
                                var dbAnswer = await _answerService.GetByIdAsync<AnswerListDto>(answer.Id);
                                dbAnswer.NumberOfChoose += 1;
                                await _answerService.UpdateAsync(_mapper.Map<AnswerUpdateDto>(dbAnswer));
                            }

                        }
                        var dbQuestion = await _questionService.GetByIdAsync<QuestionListDto>(question.Id);
                        dbQuestion.NumberOfAnswers += 1;

                        await _questionService.UpdateAsync(_mapper.Map<QuestionUpdateDto>(dbQuestion));
                    }
                }
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> AnalizeForm(int id)
        {
            var formListDto = await _formService.GetByIdAsync<FormListDto>(id);
            bool isItDigit = true;
            AnswerListDto LeastSelectedAnswer;
            AnswerListDto MostSelectedAnswer;
            var answerParagrafKisayanitSum = 0;

            if (formListDto.Questions != null)
            {
                foreach (var question in formListDto.Questions)
                {
                    if (question.QuestionType == Common.Enums.QuestionType.CoktanSecmeli || question.QuestionType == Common.Enums.QuestionType.OnayKutulari)
                    {
                        if (question.Answers != null)
                        {
                            isItDigit = true;

                            var answerchoosesum = question.Answers.Sum(i => i.NumberOfChoose);
                            if (answerchoosesum != 0)
                            {
                                foreach (var answer in question.Answers)
                                {
                                    int rate = (int)((double)answer.NumberOfChoose / answerchoosesum * 100);
                                    answer.ChoiceRate = rate;
                                }
                            }
                            else
                            {
                                foreach (var answer in question.Answers)
                                {
                                    answer.ChoiceRate = 0;
                                }
                            }

                            var mostSelectedAnswer = question.Answers.Max(i => i.NumberOfChoose);
                            var leastedSelectedAnswer = question.Answers.Min(i => i.NumberOfChoose);
                            question.Answers.Where(i => i.NumberOfChoose == mostSelectedAnswer).FirstOrDefault().IsItMostSelected = true;
                            question.Answers.Where(i => i.NumberOfChoose == leastedSelectedAnswer).FirstOrDefault().IsItLeastSelected = true;

                            var max = question.Answers.Where(i => i.IsItMostSelected).FirstOrDefault();
                            var min = question.Answers.Where(i => i.IsItLeastSelected).FirstOrDefault();
                        }
                    }
                    else
                    {
                        if (question.QuestionType == Common.Enums.QuestionType.Paragraf || question.QuestionType == Common.Enums.QuestionType.KisaYanit)
                        {
                            if (question.Answers != null)
                            {
                                foreach (var answer in question.Answers)
                                {
                                    if (answer.answerType == Common.Enums.AnswerType.text)
                                    {
                                        isItDigit = false;
                                    }
                                }
                                if (isItDigit == true)
                                {
                                    answerParagrafKisayanitSum = question.Answers.Sum(i => Int16.Parse(i.Description));
                                    var answers = await _answerService.GetAllAsync();
                                    var answerNumber = answers.Where(i => i.QuestionId == question.Id && i.IsItUserAnswer == true).Count();
                                    if (answerNumber > 0)
                                    {
                                        question.AverageAnswersValue = answerParagrafKisayanitSum / answerNumber;
                                        question.MinAnsweresValue = question.Answers.Min(i => Int16.Parse(i.Description));
                                        question.MaxAnsweresValue = question.Answers.Max(i => Int16.Parse(i.Description));
                                    }

                                }
                            }
                        }
                    }
                }
            }

            return View(formListDto);

        }

        public async Task<IActionResult> FormDownload(int id)
        {
            using (var workbook = new XLWorkbook())
            {
                var formListDto = await _formService.GetByIdAsync<FormListDto>(id);
                var quesitons = formListDto.Questions.ToList();
                var currentRow = 1;
                var worksheet = workbook.Worksheets.Add("Questions");


                for (int i = 0; i < quesitons.Count(); i++)
                {

                    worksheet.Cell(1, (i + 1)).Value = quesitons[i].QuestionTitle;



                    for (int j = 0; j < quesitons[i].Answers.Count; j++)
                    {
                        worksheet.Cell(j + 2, (i + 1)).Value = quesitons[i].Answers[j].Description;
                    }
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "questions.xlsx");

                }
            }
        }
        public async Task<IActionResult> AuthorizationShare(int id)
        {
            var formListDto = await _formService.GetByIdAsync<FormListDto>(id);
            var dto = new ControllerAddAuthorizeDto()
            {
                FormId = id,
            };
            return View(dto);
        }
        [HttpPost]
        public async Task<IActionResult> AuthorizationShare(ControllerAddAuthorizeDto dto)
        {
            var forms = await _formService.GetQuestionWithAnswersAndUsers();
            var formListDto = forms.FirstOrDefault(i => i.Id == dto.FormId);
            var formListDto1 = await _formService.GetByIdAsync<FormListDto>(dto.FormId);
            var UserToBeAdded = await _userManager.FindByNameAsync(dto.Email);
            if (UserToBeAdded != null)
            {

                if (formListDto.appUsers.Select(i => i.Name).Contains(UserToBeAdded.Name) == true)
                {
                    ModelState.AddModelError("", "Bu kullanıyı daha önce eklediniz");
                    return View(dto);
                }

                UserToBeAdded.Forms.Add(_mapper.Map<Form>(formListDto));
                await _userManager.UpdateAsync(UserToBeAdded);

                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Girdiğiniz Email ile eşleşen kullanıcı bulunamadı");
                return View(dto);
            }


        }

        
        public async Task<IActionResult> CreateOperation(int? id, ControllerCreateOperationDto? createOperationDto)
        {
            var mainQuestion = await _questionService.GetByIdAsync<QuestionListDto>(id.Value);
            var formListDto = await _formService.GetByIdAsync<FormListDto>(mainQuestion.FormId);
           

            var quesitons = formListDto.Questions.Where(i => i.QuestionType == QuestionType.KisaYanit || i.QuestionType == QuestionType.Paragraf).ToList();
            createOperationDto.questionListDtos = quesitons;
            if (id != null)
            {
                createOperationDto.MainQuesitonId = id.Value;
            }

            if (createOperationDto.SelectedQuestionId1 != 0 && createOperationDto.SelectedQuestionId1 != 0 && createOperationDto.operandType != 0)
            {
                var question1 = await _questionService.GetByIdAsync<QuestionListDto>(createOperationDto.SelectedQuestionId1);
                var question2 = await _questionService.GetByIdAsync<QuestionListDto>(createOperationDto.SelectedQuestionId2);
            }

            return View(createOperationDto);
        }


        
    }


}

