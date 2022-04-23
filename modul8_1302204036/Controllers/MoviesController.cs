using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul8_1302204036.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private static List<string> Stars1 = new List<string> {
            "Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler"
        };

        private static List<string> Stars2 = new List<string> {
            "Marlon Brando", "Heath Ledger", "Aaron Echart", "Michael Caine"
        };

        private static List<string> Stars3 = new List<string>
        {
            "Christian Bale", "Al Pacino", "James Caan", "Diana Keaton"
        };

        private readonly ILogger<MoviesController> _looger;

        List<Movie> movie1 = new List<Movie>();

        public MoviesController(ILogger<MoviesController> looger)
        {
            _looger = looger;
        }

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            movie1.Add(new Movie("Fullmetal Alcemist", "Hiromu Arakawa", Stars1, "The basic basic synopsis of the story is about 'The Fullmetal Alchemist' Edward Elric, and his brother, Alphonse Elric, and their quest of searching for the ."));
            movie1.Add(new Movie("Gintama", "Hideaki Sorachi", Stars2, "The series focuses on an eccentric samurai, Gintoki Sakata who works as an odd-jobs freelancer. "));
            movie1.Add(new Movie("Spy x Family", "Jun Maeda", Stars3, "Operating as Westalis' master spy, Twilight works tirelessly to prevent extremists from sparking a war with neighboring country. "));

        }
    }
}
