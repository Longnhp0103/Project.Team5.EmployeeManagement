using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SemesterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
