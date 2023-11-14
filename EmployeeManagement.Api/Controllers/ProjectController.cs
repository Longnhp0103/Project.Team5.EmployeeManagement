using EmployeeManagement.Repository.Models;
using EmployeeManagement.Repository.Repositories;
using EmployeeManagement.Service;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectController : ControllerBase
{
    IProjectService projectService;
    public ProjectController(IProjectService projectService)
    {
        this.projectService = projectService;
    }
    
    [HttpGet("GetProject/{id}")]
    public ActionResult<Project> GetProjectId(int id)
    {
        return Ok(projectService.GetProjectId(id));
    }
}
