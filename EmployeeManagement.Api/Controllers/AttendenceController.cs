using EmployeeManagement.Repository.Models;
using EmployeeManagement.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendenceController : ControllerBase
    {
        IAttendenceService attendenceService;
        IEmployeeService employeeService;
        public AttendenceController (IEmployeeService employeeService, IAttendenceService attendenceService)
        {
            this.employeeService = employeeService;
            this.attendenceService = attendenceService;
        }
        [HttpGet("GetEmployee/{id}")]
        public ActionResult<Employee> GetEmployee(int id)
        {
            return Ok(employeeService.GetEmployeeById(id));
        }
        [HttpGet("GetAttendence/{id}")]
        public ActionResult<Attendence> GetAttendence(int id)
        {
            return Ok(attendenceService.GetAttendenceId(id));
        }
    }
}
