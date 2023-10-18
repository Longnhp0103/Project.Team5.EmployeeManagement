using EmployeeManagement.Repository.Models;

namespace EmployeeManagement.Repository.Repositories
{
    public class SemesterRepository : GenericRepository<Semester>, ISemesterRepository
    {
        public SemesterRepository(EmployeeManagementContext dbContext) : base(dbContext)
        {
        }
    }
}
