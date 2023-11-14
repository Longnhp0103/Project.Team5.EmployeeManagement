using EmployeeManagement.Repository.Models;
using EmployeeManagement.Repository.Repositories;

namespace EmployeeManagement.Service
{
    public class AttendenceService : IAttendenceService
    {
        IAttendenceRepository attendenceRepository;
        public AttendenceService(IAttendenceRepository attendenceRepository)
        {
            this.attendenceRepository = attendenceRepository;
        }
        public Attendence GetAttendenceId(int id)
        {
            Attendence attendence = attendenceRepository.GetById(id);
            return attendence;
        }
    }
}
