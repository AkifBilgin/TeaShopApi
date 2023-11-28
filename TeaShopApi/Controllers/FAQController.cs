using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeaShopApi.BusinessLayer.Abstract;
using TeaShopApi.DtoLayer.FAQDto;
using TeaShopApi.EntityLayer.Concrete;

namespace TeaShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FAQController : ControllerBase
    {
        private readonly IFAQService _faqService;

        public FAQController(IFAQService faqService)
        {
            _faqService = faqService;
        }

        [HttpGet]
        public IActionResult FAQ()
        {
            var values = _faqService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateFAQ(CreateFAQDto createFAQDto)
        {
            FQA faq = new FQA()
            {
                Answer = createFAQDto.Answer,
                Question = createFAQDto.Question,
            };
            _faqService.TInsert(faq);
            return Ok("Frage wurde erfolgreich hinzugefügt");
        }

        [HttpDelete]
        public IActionResult DeleteFAQ(int id)
        {
            var valueToDelete = _faqService.TGetById(id);
            _faqService.TDelete(valueToDelete);
            return Ok("Frage wurde erfolgreich gelöscht");
        }

        [HttpGet("{id}")]
        public IActionResult GetFAQById(int id) 
        {
            var value = _faqService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateFAQ(UpdateFAQDto updateFAQDto)
        {

            FQA faq = new FQA()
            {
                FQAID = updateFAQDto.FQAID,
                Answer = updateFAQDto.Answer,
                Question = updateFAQDto.Question,
            };
            _faqService.TUpdate(faq);

            return Ok("FAQ erfolgreich geändert");
        }
    }
}
