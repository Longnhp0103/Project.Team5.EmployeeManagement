using EmployeeManagement.Repository.Models;
using EmployeeManagement.Service;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeamController : ControllerBase
{
    private ITeamService teamService;

    TeamController(ITeamService teamService)
    {
        this.teamService = teamService;
    }

    [HttpGet("GetAll")]
    public IActionResult GetAll()
    {
        return Ok(teamService.GetTeams());
    }

    [HttpGet("GetEmployee/{id}")]
    public IActionResult GetTeam(int id)
    {
        return Ok(teamService.GetTeamById(id));
    }

    [HttpDelete("Delete/{id}")]
    public ActionResult DeleteTeam(int id)
    {
        teamService.DeleteTeam(id);
        return Ok();
    }

    [HttpPut("Update/{id}")]
    public ActionResult UpdateTeam(Team team)
    {
        teamService.UpdateTeam(team);
        return Ok();
    }

    [HttpPost("Create")]
    public ActionResult CreateTeam(Team team)
    {
        if (team == null)
        {
            return BadRequest("Data Invalid");
        }
        teamService.CreateTeam(team);
        return Ok();
    }

    [HttpPost("CreateTeamWorkingShift")]
    public ActionResult CreateTeamWorkingShift(TeamWorkingShift teamWorkingShift)
    {
        if (teamWorkingShift == null)
        {
            return BadRequest("Data Invalid");
        }
        teamService.CreateTeamWrokingShift(teamWorkingShift);
        return Ok();
    }
}
