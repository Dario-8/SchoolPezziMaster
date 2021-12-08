using Microsoft.EntityFrameworkCore;
using SchoolPezziMaster.Services;

namespace SchoolPezziMaster
{
    public class SchoolDbContext : DbContext
    {
        DbSet<Teacher> Teachers { get; set; }
        DbSet<Course> Courses { get; set; }
        DbSet<Student> Students { get; set; }

        //SchoolDbContext(DbContextOptions options) : base(options)
        //{

        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Person>().ToTable("Persons");
        //}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                    .ToTable("Persons")
                    .HasDiscriminator<int>("PersonType")
                    .HasValue<Teacher>(1)
                    .HasValue<Student>(2);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(
                    @"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SchoolMasterPezzi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
