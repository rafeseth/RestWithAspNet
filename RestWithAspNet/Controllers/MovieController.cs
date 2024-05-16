using Microsoft.AspNetCore.Mvc;
using RestWithAspNet.Business;
using RestWithAspNet.Data.VO;
using RestWithAspNet.Model;

namespace RestWithAspNet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly ILogger<MovieController> _logger;
        private IMovieBusiness _movieBusiness;
        public MovieController(ILogger<MovieController> logger, IMovieBusiness movieBusiness)
        {
            _logger = logger;
            _movieBusiness = movieBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_movieBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var Book = _movieBusiness.FindById(id);
            if (Book == null)
            {
                return NotFound();
            }
            return Ok(Book);
        }

        [HttpPost]
        public IActionResult Create([FromBody] MovieVO movie)
        {
            if (movie == null)
            {
                return BadRequest();
            }
            _movieBusiness.Create(movie);
            return Ok(movie);
        }

        [HttpPut]
        public IActionResult Update([FromBody] MovieVO movie)
        {
            if (movie == null)
            {
                return BadRequest();
            }
            _movieBusiness.Update(movie);
            return Ok(movie);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _movieBusiness.Delete(id);
            return NoContent();
        }

    }
}
