using DadJokesBusinessLogicLayer;
using DadJokesDataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace DadJokesAPI_MultiTier.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DadJokesController : ControllerBase
	{
		private readonly IDadJokesService _jokesService;

        public DadJokesController(IDadJokesService dadJokesService)
        {
			_jokesService = dadJokesService;

		}

        // GET: api/DadJokes
        [HttpGet]
		public IActionResult Get()
		{
			return Ok(_jokesService.GetAllJokes());
		}

		// GET: api/DadJokes/5
		[HttpGet("{id}")]
		public IActionResult Get(int id)
		{
			var joke = _jokesService.GetJoke(id);
			if (joke == null)
			{
				return NotFound();
			}
			return Ok(joke);
		}

		// POST: api/DadJokes
		[HttpPost]
		public IActionResult Post([FromBody] DadJoke joke)
		{
			_jokesService.AddJoke(joke);

			return CreatedAtAction(nameof(Get), new { id = joke.Id }, joke);
		}

		// PUT: api/DadJokes/5
		[HttpPut("{id}")]
		public IActionResult Put(int id, [FromBody] DadJoke joke)
		{
			var existingJoke = _jokesService.GetJoke(id);

			if (existingJoke == null)
			{
				return NotFound();
			}
			existingJoke.Joke = joke.Joke;

			existingJoke.Punchline = joke.Punchline;

			return NoContent();
		}

		// DELETE: api/DadJokes/5
		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			var joke = _jokesService.GetJoke(id);
			if (joke == null)
			{
				return NotFound();
			}
			_jokesService.DeleteJoke(id);

			return NoContent();
		}
	}
}
