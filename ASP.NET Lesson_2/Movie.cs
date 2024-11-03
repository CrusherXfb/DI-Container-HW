using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET_Lesson_2
{
	public class Movie
	{
		public int Id { get; set; }
		public string? Title { get; set; }
		public string? Description { get; set; }
		public DateOnly DateRelease { get; set; }

		public override string ToString()
		{
			return $"Название: {Title}\n" +
				   $"Описание: {Description}\n" +
				   $"Дата выхода: {DateRelease.ToString("D")}";
		}
	}

}
