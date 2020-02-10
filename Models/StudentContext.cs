using Microsoft.EntityFrameworkCore;
namespace CoolApi.Models

{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options):base(options)
        {}
        public DbSet<Student>students{get;set;}
    }
}