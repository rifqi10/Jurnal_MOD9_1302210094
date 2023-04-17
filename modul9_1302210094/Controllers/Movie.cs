using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel;
using System.Reflection;
using modul9_1302210094;

namespace modul9_1302210094.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Movie : ControllerBase
    {
        public static List<Moviee> _data = new List<Moviee>
        {
           new Moviee
           (
               "The Shawshank Redemption (1994)",
               " Frank Darabont",
               new List<string>{" Tim Robbins, Morgan Freeman, Bob Gunton, William Sadler"},
               "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion."
           ),
           new Moviee
           (
               "The Godfather (1972)",
               "Francis Ford Coppola",
               new List<string>{"Marlon Brando, Al Pacino, James Caan, Diane Keaton"},
               "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."
           ),
            new Moviee
           (
               "The Dark Knight (2008)",
               " Christopher Nolan",
               new List<string>{" Christian Bale, Heath Ledger, Aaron Eckhart, Michael Caine"},
               "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice."
           )
        };
        // GET: api/<Movie>
        [HttpGet]
        public IEnumerable<Moviee> Get()
        {
            return _data;
        }

        // GET: api/<Movie>/5
        [HttpGet("{id}")]
        public Moviee Get(int id)
        {
            if(id < 0 || id >= _data.Count)
            {
                NotFound();
            }
            return _data[id];
        }

        // POST api/<Movie>
        [HttpPost]
        public void post([FromBody] Moviee value) 
        {
            _data.Add(value);
        }

        //DELETE api/<Movie>
        [HttpDelete("{id}")]
        public void delete(int id)
        {
            if (id < 0 || id >= _data.Count)
            {
                NotFound();
            }
            _data.RemoveAt(id);
        }
    }
}
