using EmployeeManagement.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Repository.Repositories
{
    public class TeamRepository : GenericRepository<Team>, ITeamRepository
    {
        public TeamRepository(EmployeeManagementContext dbContext) : base(dbContext)
        {
        }

        public async Task<Team> GetTeamByName(string name)
        {
            return await _dbContext.Teams.FirstOrDefaultAsync(t => t.Name.Contains(name));
        }

    }
}
