using EmployeeManagement.Repository.Models;
using EmployeeManagement.Service;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{

    IEmployeeService employeeService;
    public EmployeeController(IEmployeeService employeeService)
    {
        this.employeeService = employeeService;
    }

    [HttpGet("GetAll")]
    public IActionResult GetAll()
    {
        return Ok(employeeService.GetAllEmployee());
    }

    [HttpGet("GetEmployee/{id}")]
    public IActionResult GetEmployee(int id)
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
