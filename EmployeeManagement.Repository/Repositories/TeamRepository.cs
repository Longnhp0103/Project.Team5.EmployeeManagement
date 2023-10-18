using EmployeeManagement.Repository.Models;

namespace EmployeeManagement.Repository.Repositories
{
    public class TeamRepository : GenericRepository<Team>, ITeamRepository
    {
        public TeamRepository(EmployeeManagementContext dbContext) : base(dbContext)
        {
        }
    }
}
