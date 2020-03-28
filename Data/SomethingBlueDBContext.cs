using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore.Sqlite.Design;
using Microsoft.EntityFrameworkCore.Design;


namespace SomethingBlue.Data
{
    public class SomethingBlueDBContext : DbContext
    {
        public SomethingBlueDBContext(DbContextOptions<SomethingBlueDBContext> options)
        : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

        //public DbSet<Event> Events { get; set; }
        //public DbSet<ColorPicker> Colors { get; set; }
        //public DbSet<TimeLine> Tasks { get; set; }
        //public DbSet<Image> Images { get; set; }
        //public DbSet<Message> Messages { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");




            //modelBuilder.Entity<Event>().ToTable("Events");
            //modelBuilder.Entity<Planner>().ToTable("Planners");

            //modelBuilder.Entity<ColorPicker>().ToTable("Colors");
            //modelBuilder.Entity<TimeLine>().ToTable("Tasks");

        }
    }
}
