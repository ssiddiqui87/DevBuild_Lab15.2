using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_15._2.Models;
using Lab_15._2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab_15._2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private IDAL dal;

        public CategoryController(IDAL dalObject)
        {
            dal = dalObject;
        }

        [HttpGet]
        public IEnumerable<Movie> Get(string category)
        {
            return dal.GetAllMoviesByCategory(category);
        }

        [HttpGet("{random}")]
        public Movie GetRandomMovieByCategory(string category)
        {
            return dal.GetRandomMovieByCategory(category);
        }
    }
}