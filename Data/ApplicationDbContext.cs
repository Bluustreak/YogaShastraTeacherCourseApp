


namespace YogaShastraTeacherCourseApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        //public DbSet<Test> TestsInputs { get; set; }
        public DbSet<TeacherCourse> TeacherCourses { get; set; }
    }
}