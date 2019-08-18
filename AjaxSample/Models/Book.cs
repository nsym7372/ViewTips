using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxSample.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Publication { get; set; }
    }
}