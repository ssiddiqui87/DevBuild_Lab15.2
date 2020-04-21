using Lab_15._2.Models;
using System.Collections.Generic;


namespace Lab_15._2.Services
{
    public interface IDAL
    {
        IEnumerable<Movie> GetAllMovies();
        IEnumerable<Movie> GetAllMoviesByCategory(string category);
        Movie GetRandomMovie();
        Movie GetRandomMovieByCategory(string category);
    }
}
