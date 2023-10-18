using EmployeeManagement.Repository.Models;

namespace EmployeeManagement.Repository.Repositories
{
    public class TeamWorkingShiftRepository : GenericRepository<TeamWorkingShift>, ITeamWorkingShiftRepository
    {
        public TeamWorkingShiftRepository(EmployeeManagementContext dbContext) : base(dbContext)
        {
        }
    }
}
