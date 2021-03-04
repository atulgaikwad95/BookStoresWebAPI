using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoresWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookStoresWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       

        [HttpGet]
        public IEnumerable<Publisher> Get()
        {
            //CRUD
             using(var _context = new BookStoresDbContext())
            {
                /* Publisher publisher = new Publisher();                       // way to Add Data into table in Database      
                 publisher.PublisherName = "Shivaji Sawant";

                 _context.Publishers.Add(publisher);

                 _context.SaveChanges();*/


                //  return _context.Publishers.ToList();                      // way to Read Data From Table in Json Format


                /* Publisher publisher = _context.Publishers.Find(16);        // way to update Data from Table
                 publisher.PublisherName = "Akash Sharma";
                 _context.SaveChanges();
                 return _context.Publishers.ToList();*/


                Publisher publisher = _context.Publishers.Find(16);           // Delete The Data from Table
                _context.Publishers.Remove(publisher);
                _context.SaveChanges();
                return _context.Publishers.ToList();

            }

          //  return new List<Publisher>();
        }
    }
}
