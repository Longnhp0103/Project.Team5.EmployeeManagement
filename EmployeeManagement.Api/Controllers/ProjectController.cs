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

    [HttpGet("GetAll")]
    public IActionResult GetAll()
    {
        return Ok(projectService.GetAllProjects());
    }

    [HttpDelete("Delete/{id}")]
    public ActionResult DeleteProject(int id)
    {
        projectService.DeleteProject(id);
        return Ok();
    }

    [HttpPut("Update/{id}")]
    public ActionResult UpdateProject(Project project)
    {
        projectService.UpgradeProject(project);
        return Ok();
    }

    [HttpPost("Create")]
    public ActionResult CreateProject(Project project)
    {
        if (project == null)
        {
            return BadRequest("Data Invalid");
        }
        projectService.CreateProject(project);
        return Ok();
    }
}
