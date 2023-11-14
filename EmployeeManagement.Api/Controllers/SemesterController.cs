using EmployeeManagement.Repository.Models;
using EmployeeManagement.Repository.Repositories;
using EmployeeManagement.Service;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SemesterController : ControllerBase
{
    ISemesterService semesterService;
    public SemesterController(ISemesterService semesterService)
    {
        this.semesterService = semesterService;
    }

    [HttpGet("GetSemester/{id}")]
    public ActionResult<Semester> GetSemesterId(int id)
    {
        return Ok(semesterService.GetSemesterId(id));
    }
}
