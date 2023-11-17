using EmployeeManagement.Repository.Models;
using EmployeeManagement.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamWorkingShiftController : ControllerBase
    {
        ITeamWorkingShiftService teamWorkingShiftService;
        ITeamService teamService;
        IScheduleService scheduleService;
        public TeamWorkingShiftController(ITeamWorkingShiftService teamWorkingShiftService, ITeamService teamService, IScheduleService scheduleService)
        {
            this.teamWorkingShiftService = teamWorkingShiftService;
            this.teamService = teamService;
            this.scheduleService = scheduleService;
        }

        [HttpGet("GetTeamWorkingShiftId/{id}")]
        public ActionResult<TeamWorkingShift> GetTeamWorkingShift(int id)
        {
            return Ok(teamWorkingShiftService.GetTeamWorkingShiftId(id));
        }

        [HttpGet("GetTeamId/{id}")]
        public ActionResult<Team> GetTeam(int id)
        {
            return Ok(teamService.GetTeamById(id));
        }

        [HttpGet("GetScheduleId/{id}")]
        public ActionResult<Schedule> GetSchedule(int id)
        {
            return Ok(scheduleService.GetScheduleId(id));
        }

        [HttpGet("GetAllTeamWorkingShift")]
        public IActionResult GetAll()
        {
            return Ok(teamWorkingShiftService.GetWorkingShifts());
        }

        [HttpDelete("DeleteTeamWorkingShift/{id}")]
        public ActionResult DeleteTeamWorkingShift(int id)
        {
            teamWorkingShiftService.DeleteTeamWorkingShift(id);
            return Ok();
        }

        [HttpPut("UpdateTeamWorkingShift/{id}")]
        public ActionResult UpdateTeamWorkingShift(TeamWorkingShift teamWorkingShift)
        {
            teamWorkingShiftService.UpdateTeamWorkingShift(teamWorkingShift);
            return Ok();
        }

        [HttpPost("CreateTeamWorkingShift")]
        public ActionResult CreateTeamWorkingShift(TeamWorkingShift teamWorkingShift)
        {
            if (teamWorkingShift == null)
            {
                return BadRequest("Data Invalid");
            }
            teamWorkingShiftService.CreateTeamWorkingShift(teamWorkingShift);
            return Ok();
        }
    }
}
