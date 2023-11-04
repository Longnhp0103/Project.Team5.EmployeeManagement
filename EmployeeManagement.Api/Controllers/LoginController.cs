using EmployeeManagement.Repository.Models;
using EmployeeManagement.Service;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace EmployeeManagement.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LoginController : ControllerBase
{
    IRoleService roleService;
    IEmployeeService employeeService;
    private readonly IConfiguration Configuration;
    public LoginController(IRoleService roleService, IEmployeeService employeeService, IConfiguration configuration)
    {
        this.roleService = roleService;
        this.employeeService = employeeService;
        Configuration = configuration;
    }

    public class LoginInformation
    {
        public string email { get; set; }
        public string password { get; set; }
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

    [HttpPost("authentication")]
    [Consumes(MediaTypeNames.Application.Json)]
    public async Task<ActionResult<Employee>> Authentication(LoginInformation loginInformation)
    {
        Employee employee =  employeeService.Authentication(loginInformation.email, loginInformation.password);
        if (employee == null)
        {
            //if get member from database is null, check if it was the admin

            if (loginInformation.email.Equals(Configuration["Admin:Email"], StringComparison.OrdinalIgnoreCase) && loginInformation.password.Equals(Configuration["Admin:Password"]))
            {
                return new Employee { Email = Configuration["Admin:Email"], Password = Configuration["Admin:Password"],isAdmin = true };
            }

            return NotFound();
        }

        return Ok(employee);
    }


}
