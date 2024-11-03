using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET_Lesson_2
{
	public class RepositoryMovieADO : IRepositoryMovie
	{
		private readonly string cs = "Data Source=DESKTOP-7P2T3B9\\SQLEXPRESS01;Initial Catalog=MyMovies;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

		public async Task<List<Movie>> GetAll()
		{
			var movies = new List<Movie>();

			using (var connection = new SqlConnection(cs))
			{
				await connection.OpenAsync();
				using (var command = new SqlCommand(
					"Select Id, Title, Description, DateRelease " +
					"From Movies", 
					connection))
				{
					using (var reader = await command.ExecuteReaderAsync())
					{
						while (await reader.ReadAsync())
						{
							var movie = new Movie
							{
								Id = reader.GetInt32(0),
								Title = reader.GetString(1),
								Description = reader.GetString(2),
								DateRelease = DateOnly.FromDateTime(reader.GetDateTime(3))
							};
							movies.Add(movie);
						}
					}
				}
			}

			return movies;
		}

		public async Task<Movie> GetById(int id)
		{
			Movie movie = null;

			using (var connection = new SqlConnection(cs))
			{
				await connection.OpenAsync();
				using (var command = new SqlCommand(
					"Select Id, Title, Description, DateRelease " +
					"From Movies " +
					"Where Id = @Id", 
					connection))
				{
					command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = id });

					using (var reader = await command.ExecuteReaderAsync())
					{
						if (await reader.ReadAsync())
						{
							movie = new Movie
							{
								Id = reader.GetInt32(0),
								Title = reader.GetString(1),
								Description = reader.GetString(2),
								DateRelease = DateOnly.FromDateTime(reader.GetDateTime(3))
							};
						}
					}
				}
			}

			return movie;
		}
	}
}
