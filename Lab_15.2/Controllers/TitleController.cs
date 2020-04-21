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
    public class TitleController : ControllerBase
    {
        private IDAL dal;

        public TitleController(IDAL dalObject)
        {
            dal = dalObject;
        }

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return dal.GetAllMovies();
        }

        [HttpGet("{random}")]
        public Movie GetRandomMovie()
        {
            return dal.GetRandomMovie();
        }
    }
}