using EmployeeManagement.Repository.Models;
using EmployeeManagement.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeWorkingShiftController : ControllerBase
    {
        IEmployeeWorkingShiftService employeeWorkingShiftService;
        public EmployeeWorkingShiftController(IEmployeeWorkingShiftService employeeWorkingShiftService)
        {
            this.employeeWorkingShiftService = employeeWorkingShiftService;
        }
        [HttpGet("GetEmployeeWorkingShift/{id}")]
        public ActionResult<EmployeeWorkingShift> GetEmployeeWorkingShiftId(int id)
        {
            return Ok(employeeWorkingShiftService.GetEmployeeWorkingShiftId(id));
        }
    }
}
