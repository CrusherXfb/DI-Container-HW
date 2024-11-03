using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET_Lesson_2
{
	public interface IRepositoryMovie
	{
		Task<List<Movie>> GetAll();
		Task<Movie> GetById(int id);
	}
}
