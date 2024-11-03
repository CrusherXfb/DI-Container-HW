using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET_Lesson_2
{
	public interface IShowData
	{
		void ShowAllData(List <Movie> movies);
		void ShowData(string movie_string);
	}
}
