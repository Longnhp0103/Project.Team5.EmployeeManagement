using EmployeeManagement.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Repository.Repositories
{
    public class TeamRepository : GenericRepository<Team>, ITeamRepository
    {
        public TeamRepository(EmployeeManagementContext dbContext) : base(dbContext)
        {
        }

        public bool ChangeTeamStatus(int teamId)
        {
            try
            {
                // Retrieve the team from the database
                var team = _dbContext.Teams.FirstOrDefault(t => t.Id == teamId);

                if (team != null)
                {
                    // Toggle the team status
                    team.Status = !team.Status;

                    // Save changes to the database
                    _dbContext.SaveChanges();

                    // Return true to indicate success
                    return true;
                }
                else
                {
                    // Team not found, return false
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during the operation
                // Log the exception, return false, or throw a custom exception as needed
                // Example: Console.WriteLine($"Error changing team status: {ex.Message}");
                return false;
            }
        }



        public async Task<Team> GetTeamByName(string name)
        {
            return await _dbContext.Teams.FirstOrDefaultAsync(t => t.Name.Contains(name));
        }

    }
}
