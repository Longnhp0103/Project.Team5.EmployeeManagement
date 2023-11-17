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
            throw new NotImplementedException();
        }

        public void DeleteTeamWorkingShift(int id)
        {
            throw new NotImplementedException();
        }

        public TeamWorkingShift GetTeamWorkingShiftId(int id)
        {
            throw new NotImplementedException();
        }

        public List<TeamWorkingShift> GetWorkingShifts()
        {
            throw new NotImplementedException();
        }

        public void UpdateTeamWorkingShift(TeamWorkingShift teamWorkingShift)
        {
            throw new NotImplementedException();
        }
    }
}
