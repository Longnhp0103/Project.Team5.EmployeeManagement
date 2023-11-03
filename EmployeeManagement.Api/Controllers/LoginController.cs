using EmployeeManagement.Repository.Models;
using EmployeeManagement.Service;
using Microsoft.AspNetCore.Mvc;



namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : Controller
    {
        IRoleService roleService;
        IEmployeeService employeeService;
        public LoginController(IRoleService roleService, IEmployeeService employeeService)
        {
            this.roleService = roleService;
            this.employeeService = employeeService;
        }


        [HttpGet("GetEmployee/{id}")]
        public ActionResult<Employee> GetEmployee(int id)
        {
            return Ok(employeeService.GetEmployeeById(id));
        }

        [HttpGet("GetRole/{id}")]
        public ActionResult<Employee> GetStaffAccount(int id)
        {
            return Ok(roleService.GetStaffAccount(id));
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
