using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModalDIalog.Models
{
    using System.Data.Entity;
    using ModalDIalog.Models;
    public class SampleDBContext : DbContext
    {
        public SampleDBContext()
        { }

        public DbSet<Person> People { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}