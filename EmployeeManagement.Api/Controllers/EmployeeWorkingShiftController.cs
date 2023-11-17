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
        [HttpGet("GetAllEmployeeWorkingShift")]
        public IActionResult GetAll()
        {
            return Ok(employeeWorkingShiftService.GetAll());
        }

        [HttpDelete("DeleteEmployeeWorkingShift/{id}")]
        public ActionResult Delete(int id)
        {
            employeeWorkingShiftService.DeleteEmployeeWorkingShift(id);
            return Ok();
        }

        [HttpPut("UpdateEmployeeWorkingShift/{id}")]
        public ActionResult UpdateEmployeeWorkingShift(EmployeeWorkingShift employeeWorkingShift)
        {
            employeeWorkingShiftService.UpdateEmployeeWorkingShift(employeeWorkingShift);
            return Ok();
        }
        [HttpPost("CreateEmployeeWorkingShift")]
        public ActionResult CreateEmployeeWorkingShift(EmployeeWorkingShift employeeWorkingShift, int id)
        {
            if(employeeWorkingShift == null)
            {
                return BadRequest("Data Invalid");
            }
            employeeWorkingShiftService.CreateEmployeeWorkingShift(employeeWorkingShift);
            return Ok();
        }
    }
}
