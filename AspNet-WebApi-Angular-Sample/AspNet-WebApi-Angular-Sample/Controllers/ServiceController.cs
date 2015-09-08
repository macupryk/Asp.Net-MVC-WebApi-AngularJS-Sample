using AspNet_WebApi_Angular_Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspNet_WebApi_Angular_Sample.Controllers
{
    public class ServiceController : ApiController
    {
        //Data Source : http://www.computerworld.com/article/2473702/it-careers/it-careers-97819-top-10-programming-skills-that-will-get-you-hired.html

        Lang[] langInformations = new Lang[]
        {
            new Lang {ID=1,Name="C#",JobCount="31,936",TopCities="Seattle , New York , Boston , Chigago" ,TopEmployers="Microsoft , Amazon , HP , Dell , Intel"},
            new Lang {ID=2,Name="C++",JobCount="32,018",TopCities="Seattle , Santa Clara , New York" ,TopEmployers="Microsoft , Amazon , HP , Dell , Intel"},
            new Lang {ID=3,Name="JavaScript",JobCount="43,189",TopCities="New York , San Francisco , Washington D.C" ,TopEmployers="Amazon , Microsoft , IBM , Dell , Disney"},
            new Lang {ID=3,Name="JAVA",JobCount="66,485",TopCities="New York , Washington D.C , San Jose , Boston" ,TopEmployers="Amazon , IBM , IBM , Ebay , Deloitte"},
        };

        [HttpGet]
        public IEnumerable<Lang> GetAllLang()
        {
            return langInformations;
        }

        public IHttpActionResult GetLang(int id)
        {
            var langs = langInformations.FirstOrDefault((p) => p.ID == id);
            if (langs == null)
            {
                return NotFound();
            }
            return Ok(langs);
        }
    }
}
