using Microsoft.EntityFrameworkCore;
namespace Eleaning_Web.Model
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<Exam> Exam { get; set; }
        public DbSet<Result> Result { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Test> Test { get; set; }
        public DbSet<Subject> Subject { get; set; }
      
        public DbSet<Role> Role { get; set; }

       
    }
}
