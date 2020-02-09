namespace Validation.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SampleContext : DbContext
    {
        public SampleContext()
            : base("name=SampleContext")
        {
        }

        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Device>()
                .HasMany(e => e.People)
                .WithMany(e => e.Devices)
                .Map(m => m.ToTable("PeopleDevices").MapRightKey("People_Id"));
        }
    }
}
