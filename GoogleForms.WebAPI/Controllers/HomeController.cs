using GoogleForms.BLL.Interfaces;
using GoogleForms.DTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;



namespace GoogleForms.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        IFormService _formService;
        IQuestionService _questionService;
        IAnswerService _answerService;

        public HomeController(IFormService formService, IQuestionService questionService, IAnswerService answerService)
        {
            _formService = formService;
            _questionService = questionService;
            _answerService = answerService;
        }
        // GET: api/<HomeController>
        [HttpGet]
        public async Task<Object> GetAll()
        {
            var form = await _formService.SorulariCevaplariIleGetir();
            var json = JsonConvert.SerializeObject(form, Newtonsoft.Json.Formatting.Indented,
            new JsonSerializerSettings()
            {
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            }
        );
            return json;
        }
        [Route("[action]")]
        [HttpPost]
        public async Task<object> CreateForm([FromBody] FormCreateDto dto)
        {
            var form = await _formService.CreateAsync(dto);

            return true;
        }
        [Route("[action]")]
        [HttpPost]
        public async Task<object> CreateQuestion([FromBody] QuestionCreateDto dto)
        {
           // var form = await _formService.SoruEkle(dto);
            return true;
        }
        [Route("[action]")]
        [HttpPost]
        public async Task<object> CreateAnswer([FromBody] AnswerCreateDto dto)
        {
           // var form = await _formService.SoruEkle(dto);
            return true;
        }
    }
}
