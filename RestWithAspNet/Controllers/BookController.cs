using Microsoft.AspNetCore.Mvc;
using RestWithAspNet.Business;
using RestWithAspNet.Data.VO;
using RestWithAspNet.Model;

namespace RestWithAspNet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;
        private IBookBusiness _bookBusiness;
        public BookController(ILogger<BookController> logger, IBookBusiness bookBusiness)
        {
            _logger = logger;
            _bookBusiness = bookBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_bookBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var BookVO = _bookBusiness.FindById(id);
            if (BookVO == null)
            {
                return NotFound();
            }
            return Ok(BookVO);
        }

        [HttpPost]
        public IActionResult Create([FromBody] BookVO book)
        {
            if (book == null)
            {
                return BadRequest();
            }
            _bookBusiness.Create(book);
            return Ok(book);
        }

        [HttpPut]
        public IActionResult Update([FromBody] BookVO book)
        {
            if (book == null)
            {
                return BadRequest();
            }
            _bookBusiness.Update(book);
            return Ok(book);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _bookBusiness.Delete(id);
            return NoContent();
        }

    }
}
