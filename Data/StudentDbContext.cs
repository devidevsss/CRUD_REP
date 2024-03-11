using CRUD_REP.Model;
using Microsoft.EntityFrameworkCore;

namespace CRUD_REP.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Student> Students { get; set; }

    }
}
