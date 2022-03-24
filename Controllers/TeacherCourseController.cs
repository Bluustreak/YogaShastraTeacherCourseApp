

namespace YogaShastraTeacherCourseApp.Controllers
{
    public class TeacherCourseController : Controller
    {
        private ApplicationDbContext _dbContext;
        public TeacherCourseController(ApplicationDbContext DB)
        {
            _dbContext = DB;
        }
        // GET: TeacherCourse
        public ActionResult TCIndex()
        {
            return View();
        }

        // GET: TeacherCourse/Details/5
        public ActionResult TCDetails()
        {
            var TC = _dbContext.TeacherCourses.FirstOrDefault();
            return View();
        }

        // GET: TeacherCourse/Create
        public ActionResult TCCreate()
        {

            return View();
        }

        // POST: TeacherCourse/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TCCreate(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TeacherCourse/Edit/5
        public ActionResult TCEdit(int id)
        {
            return View();
        }

        // POST: TeacherCourse/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TCEdit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TeacherCourse/Delete/5
        public ActionResult TCDelete(int id)
        {
            return View();
        }

        // POST: TeacherCourse/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TCDelete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
