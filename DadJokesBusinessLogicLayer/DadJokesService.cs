using DadJokesDataAccessLayer;

namespace DadJokesBusinessLogicLayer
{
	public class DadJokesService : IDadJokesService
	{
		private readonly IDadJokesRepository _repository;

		public DadJokesService(IDadJokesRepository repository)
		{
			_repository = repository;
		}

		public IEnumerable<DadJoke> GetAllJokes()
		{
			return _repository.GetAllJokes();
		}

		public DadJoke GetJoke(int id)
		{
			return _repository.GetJoke(id);
		}

		public void AddJoke(DadJoke joke)
		{
			// Business logic can be added here, e.g. validation
			_repository.AddJoke(joke);
		}

		public void UpdateJoke(DadJoke joke)
		{
			_repository.UpdateJoke(joke);
		}

		public void DeleteJoke(int id)
		{
			_repository.DeleteJoke(id);
		}
	}
}
