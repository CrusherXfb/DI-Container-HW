using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET_Lesson_2
{
	public class ShowDataConsole : IShowData
	{
		public void ShowData(string movie_string)
		{
			Console.WriteLine(movie_string);
		}
	}
}
