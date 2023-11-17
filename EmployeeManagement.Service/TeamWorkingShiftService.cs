using EmployeeManagement.Repository.Models;
using EmployeeManagement.Repository.Repositories;

namespace EmployeeManagement.Service
{
    public class TeamWorkingShiftService : ITeamWorkingShiftService
    {
        ITeamWorkingShiftRepository repository;
        public TeamWorkingShiftService (ITeamWorkingShiftRepository repository)
        {
            this.repository = repository;
        }
        public void CreateTeamWorkingShift(TeamWorkingShift teamWorkingShift)
        {
            repository.Insert(teamWorkingShift);
        }

        public void DeleteTeamWorkingShift(int id)
        {
            TeamWorkingShift teamWorkingShift = repository.GetById(id);
            if(teamWorkingShift != null)
            {
                repository.Delete(teamWorkingShift.Id);
            }

        }

        public TeamWorkingShift GetTeamWorkingShiftId(int id)
        {
            return repository.GetById(id);
        }

        public List<TeamWorkingShift> GetWorkingShifts()
        {
            return(List<TeamWorkingShift>)repository.GetAll();
        }

        public void UpdateTeamWorkingShift(TeamWorkingShift teamWorkingShift)
        {
            repository.Update(teamWorkingShift);
        }
    }
}
