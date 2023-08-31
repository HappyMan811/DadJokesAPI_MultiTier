using DadJokesDataAccessLayer;

namespace DadJokesBusinessLogicLayer
{
	public interface IDadJokesService
	{
		IEnumerable<DadJoke> GetAllJokes();
		DadJoke GetJoke(int id);
		void AddJoke(DadJoke joke);
		void UpdateJoke(DadJoke joke);
		void DeleteJoke(int id);
	}
}