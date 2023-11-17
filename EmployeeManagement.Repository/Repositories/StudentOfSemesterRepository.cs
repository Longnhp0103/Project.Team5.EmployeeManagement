using EmployeeManagement.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Repository.Repositories
{
    public class StudentOfSemesterRepository : GenericRepository<StudentOfSemester>, IStudentOfSemesterRepository
    {
        public StudentOfSemesterRepository(EmployeeManagementContext dbContext) : base(dbContext)
        {
        }
    }
}
