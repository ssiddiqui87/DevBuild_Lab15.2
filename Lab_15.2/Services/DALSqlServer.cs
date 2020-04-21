using Dapper;
using Lab_15._2.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_15._2.Services
{
    public class DALSqlServer : IDAL
    {
        private string connectionString;
        public DALSqlServer(IConfiguration config)
        {
            connectionString = config.GetConnectionString("MovieDB");
        }
        public IEnumerable<Movie> GetAllMovies()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string queryString = "SELECT * FROM MovieList";

            IEnumerable<Movie> Products = connection.Query<Movie>(queryString);

            return Products;
        }

        public IEnumerable<Movie> GetAllMoviesByCategory(string category)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string queryString = "SELECT * FROM MovieList WHERE Category = @category";

            IEnumerable<Movie> Products = connection.Query<Movie>(queryString, new { category = category });

            return Products;
        }

        public Movie GetRandomMovie()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string queryString = "SELECT TOP 1 * FROM MovieList ORDER BY NEWID()";
            return connection.QueryFirstOrDefault<Movie>(queryString);
        }

        public Movie GetRandomMovieByCategory(string category)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string queryString = "SELECT TOP 1 * FROM MovieList WHERE Category = @category ORDER BY NEWID()";
            return connection.QueryFirstOrDefault<Movie>(queryString, new { category = category });
        }
    }
}
