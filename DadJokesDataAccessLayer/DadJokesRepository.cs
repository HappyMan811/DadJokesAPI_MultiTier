namespace DadJokesDataAccessLayer
{
	public class DadJokesRepository : IDadJokesRepository
	{
		private static List<DadJoke> _jokes = new List<DadJoke>();

		public IEnumerable<DadJoke> GetAllJokes()
		{
			return _jokes;
		}

		public DadJoke GetJoke(int id)
		{
			return _jokes.FirstOrDefault(j => j.Id == id);
		}

		public void AddJoke(DadJoke joke)
		{
			_jokes.Add(joke);
		}

		public void UpdateJoke(DadJoke joke)
		{
			var existingJoke = _jokes.FirstOrDefault(j => j.Id == joke.Id);
			if (existingJoke != null)
			{
				existingJoke.Joke = joke.Joke;
				existingJoke.Punchline = joke.Punchline;
			}
		}

		public void DeleteJoke(int id)
		{
			var joke = _jokes.FirstOrDefault(j => j.Id == id);
			if (joke != null)
			{
				_jokes.Remove(joke);
			}
		}
	}
}