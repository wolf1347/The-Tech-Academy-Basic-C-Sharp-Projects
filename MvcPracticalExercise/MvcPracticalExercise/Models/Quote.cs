using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPracticalExercise.Models
{
    public class Quote
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int PriceQuote { get; set; }
    }
}