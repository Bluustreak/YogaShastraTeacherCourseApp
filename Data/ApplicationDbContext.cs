

namespace YogaShastraTeacherCourseApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<TeacherCourseController> TeacherCourses { get; set; }
    }
}