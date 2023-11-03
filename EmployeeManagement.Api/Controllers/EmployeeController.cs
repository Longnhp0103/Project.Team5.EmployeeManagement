using EmployeeManagement.Repository.Models;
using EmployeeManagement.Service;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : Controller
    {

        IEmployeeService employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<Employee>> GetAll()
        {
            return Ok(employeeService.GetAllEmployee());
        }

        [HttpGet("GetEmployee/{id}")]
        public ActionResult<Employee> GetEmployee(int id)
        {
            return Ok(employeeService.GetEmployeeById(id));
        }

        [HttpDelete("Delete/{id}")]
        public ActionResult DeleteEmployee(int id)
        {
            employeeService.DeleteEmployee(id);
            return Ok();
        }

        [HttpPut("Update/{id}")]
        public ActionResult UpdateEmployee(Employee employee)
        {
            employeeService.UpdateEmployee(employee);
            return Ok();
        }

        [HttpPost("Create")]
        public ActionResult CreateEmployee(Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Data Invalid");
            }
            employeeService.CreateEmployee(employee);
            return Ok();
        }
    }
}
