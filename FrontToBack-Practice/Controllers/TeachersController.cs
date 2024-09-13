using FrontToBack_Practice.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack_Practice.Controllers
{
    public class TeachersController : Controller
    {
        private readonly AppDbContext _dbContext;
        public TeachersController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var teachers = _dbContext.Teachers.ToList();
            return View(teachers);
        }
    }
}
