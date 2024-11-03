using ASP.NET_Lesson_2;
using Microsoft.Extensions.DependencyInjection;

//var movieWriter = new MovieWriter(
//	new RepositoryMovieADO());

//await movieWriter.ShowAllMovies();
//await movieWriter.ShowMovieById(1);

var services = new ServiceCollection();
services.AddTransient<IRepositoryMovie, RepositoryMovieADO>();
services.AddTransient<IShowData, ShowDataMessageBox>();
services.AddTransient<MovieWriter>();
var serviceProvider = services.BuildServiceProvider();

var movieWriter = serviceProvider.GetService<MovieWriter>();
await movieWriter.ShowAllMovies();

