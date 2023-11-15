using EmployeeManagement.Repository.Models;

namespace EmployeeManagement.Service
{
    public interface ITeamService
    {
        Team GetTeamById(int id);
        List<Team> GetTeams();
        Task<Team> GetTeamByName(string name);
        void UpdateTeam(Team team);
        void DeleteTeam(int id);
        void CreateTeam(Team team);
        void CreateTeamWrokingShift(TeamWorkingShift teamWorkingShift);
    }
}
