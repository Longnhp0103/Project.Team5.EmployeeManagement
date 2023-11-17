using EmployeeManagement.Repository.Models;
using EmployeeManagement.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentOfSemesterController : ControllerBase
    {
        IStudentOfSemesterService studentOfSemesterService;
        IEmployeeService employeeService;
        ISemesterService semesterService;
        public StudentOfSemesterController(IStudentOfSemesterService studentOfSemesterService, IEmployeeService employeeService, ISemesterService semesterService)
        {
            this.studentOfSemesterService = studentOfSemesterService;
            this.employeeService = employeeService;
            this.semesterService = semesterService;
        }

        [HttpGet("GetEmployee/{id}")]
        public ActionResult<Employee> GetEmployee(int id)
        {
            return Ok(employeeService.GetEmployeeById(id));
        }

        [HttpGet("GetSemester/{id}")]
        public ActionResult<Semester> GetSemester(int id)
        {
            return Ok(semesterService.GetSemesterId(id));
        }

        [HttpGet("GetStudentOfSemester/{id}")]
        public ActionResult<Semester> GetStudentOfSemester(int id)
        {
            return Ok(studentOfSemesterService.GetStudentOfSemesterId(id));
        }

        [HttpGet("GetAllStudentOfSemester")]
        public IActionResult GetAll()
        {
            return Ok(studentOfSemesterService.GetStudentOfSemesterList());
        }

        [HttpDelete("DeleteStudentOfSemester/{id}")]
        public ActionResult DeleteStudentOfSemester(int id)
        {
            studentOfSemesterService.DeleteStudentOfSemester(id);
            return Ok();
        }

        [HttpPut("UpdateStudentOfSemester/{id}")]
        public ActionResult UpdateStudentOfSemester(StudentOfSemester studentOfSemester)
        {
            studentOfSemesterService.UpdateStudentOfSemester(studentOfSemester);
            return Ok();
        }

        [HttpPost("CreateStudentOfSemester")]
        public ActionResult CreateStudentOfSemester(StudentOfSemester studentOfSemester)
        {
            if (studentOfSemester == null)
            {
                return BadRequest("Data Invalid");
            }
            studentOfSemesterService.CreateStudentOfSemesterService(studentOfSemester);
            return Ok();
        }


    }
}
