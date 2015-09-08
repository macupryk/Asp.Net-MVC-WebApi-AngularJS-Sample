using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNet_WebApi_Angular_Sample.Models
{
    public class Lang
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string JobCount { get; set; }
        public string TopCities { get; set; }
        public string TopEmployers { get; set; }
    }
}