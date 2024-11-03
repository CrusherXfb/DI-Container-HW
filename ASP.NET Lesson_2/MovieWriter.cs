using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET_Lesson_2
{
	public class MovieWriter(IRepositoryMovie repositoryMovie, IShowData showData)
	{
		public async Task ShowAllMovies()
		{
			var movies = await repositoryMovie.GetAll();
			string movies_string = "";
			foreach (var movie in movies)
			{
				movies_string += movie.ToString();
			}
			showData.ShowData(movies_string);			
		}

		public async Task ShowMovieById(int id)
		{
			var movie = await repositoryMovie.GetById(id);
			showData.ShowData(movie.ToString());
		}
	}
}
