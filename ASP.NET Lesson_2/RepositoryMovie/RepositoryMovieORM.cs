using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET_Lesson_2
{
	public class RepositoryMovieORM : IRepositoryMovie
	{
		private readonly ApplicationContext applicationContext = new();
		public async Task<List<Movie>> GetAll()
		{
			return await applicationContext.Movies.ToListAsync();
		}

		public async Task<Movie> GetById(int id)
		{
			return await applicationContext.Movies.SingleAsync(movie => movie.Id == id);
		}
	}
}
