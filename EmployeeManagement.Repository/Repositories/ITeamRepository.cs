using EmployeeManagement.Repository.Models;

namespace EmployeeManagement.Repository.Repositories
{
    public interface ITeamRepository : IGenericRepository<Team>
    {
        Task<Team> GetTeamByName(string name);
    }
}
