using EmployeeManagement.Repository.Models;

namespace EmployeeManagement.Service
{
    public interface ITeamWorkingShiftService
    {
        void CreateTeamWorkingShift(TeamWorkingShift teamWorkingShift);
        List<TeamWorkingShift> GetWorkingShifts();
        TeamWorkingShift GetTeamWorkingShiftId(int id); 
        void DeleteTeamWorkingShift(int id);
        void UpdateTeamWorkingShift(TeamWorkingShift teamWorkingShift);


    }
}
