using FrontToBack_Practice.DataAccessLayer;
using FrontToBack_Practice.DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack_Practice.Controllers
{
    public class StudentsController : Controller
    {
        private readonly AppDbContext _dbContext;
        public StudentsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var students = _dbContext.Students.Include(x=>x.TeacherStudents).ThenInclude(t=>t.Teacher).ToList();
            return View(students);
        }
    }
}
