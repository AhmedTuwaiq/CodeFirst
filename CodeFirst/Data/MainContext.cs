using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Data
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions<MainContext> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>()
                .Property(r => r.Type)
                .IsRequired();
            
            generateStudents(10, modelBuilder);
        }

        private void generateStudents(int amount, ModelBuilder modelBuilder)
        {
            for (int i = 1; i <= amount; i++)
            {
                createStudent(
                    new Student()
                    {
                        ID = i,
                        Firstname = Faker.NameFaker.FirstName(),
                        Lastname = Faker.NameFaker.LastName(),
                        Email = Faker.InternetFaker.Email(),
                    }, modelBuilder);
            }
        }

        private void createStudent(Student student, ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(student);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}