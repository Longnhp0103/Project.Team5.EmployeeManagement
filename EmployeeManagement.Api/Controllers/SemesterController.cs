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

    [HttpGet("GetAllSemester")]
    public IActionResult GetAll()
    {
        return Ok(semesterService.GetSemesterList());
    }

    [HttpDelete("DeleteSemester/{id}")]
    public ActionResult DeleteSemester(int id)
    {
        semesterService.DeleteSemester(id);
        return Ok();
    }

    [HttpPut("UpdateSemester/{id}")]
    public ActionResult UpdateSemester(Semester semester)
    {
        semesterService.UpdateSemester(semester);
        return Ok();
    }

    [HttpPost("CreateSemester")]
    public ActionResult CreateSemester(Semester semester)
    {
        if (semester == null)
        {
            return BadRequest("Data Invalid");
        }
        semesterService.CreateSemester(semester);
        return Ok();
    }

}
