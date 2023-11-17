using EmployeeManagement.Repository.Models;
using EmployeeManagement.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        ScheduleService scheduleService;
        public ScheduleController(ScheduleService scheduleService)
        {
            this.scheduleService = scheduleService;
        }
        [HttpGet("GetSchedule/{id}")]
        public ActionResult<Schedule> GetScheduleId(int id)
        {
            return Ok(scheduleService.GetScheduleId(id));
        }
    }
}
