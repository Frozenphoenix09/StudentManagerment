using Microsoft.EntityFrameworkCore;
using Student.DataAcess.Entities;



namespace Student.DataAcess.EF
{
    public class StudentManagerDbContext : DbContext
    {
        public StudentManagerDbContext(DbContextOptions opt) : base(opt)
        {
        }
        public DbSet<Entities.Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }
    }
}
