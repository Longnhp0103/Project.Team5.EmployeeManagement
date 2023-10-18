using EmployeeManagement.Repository.Models;

namespace EmployeeManagement.Repository.Repositories
{
    public class ScheduleRepository : GenericRepository<Schedule>, IScheduleRepository
    {
        public ScheduleRepository(EmployeeManagementContext dbContext) : base(dbContext)
        {
        }
    }
}
