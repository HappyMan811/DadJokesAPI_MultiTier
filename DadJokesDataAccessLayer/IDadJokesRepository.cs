using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadJokesDataAccessLayer
{
	public interface IDadJokesRepository
	{
		IEnumerable<DadJoke> GetAllJokes();
		DadJoke GetJoke(int id);
		void AddJoke(DadJoke joke);
		void UpdateJoke(DadJoke joke);
		void DeleteJoke(int id);
	}
}
