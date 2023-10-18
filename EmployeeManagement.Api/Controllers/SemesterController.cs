using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers
{
    public class SemesterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
