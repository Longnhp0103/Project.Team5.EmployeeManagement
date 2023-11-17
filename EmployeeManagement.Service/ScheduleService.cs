using EmployeeManagement.Repository.Models;
using EmployeeManagement.Repository.Repositories;

namespace EmployeeManagement.Service
{
    public class ScheduleService : IScheduleService
    {
        IScheduleRepository repository;
        public ScheduleService(IScheduleRepository repository)
        {
            this.repository = repository;
        }

        public Schedule GetScheduleId(int scheduleId)
        {
           return repository.GetById(scheduleId);
        }
    }
}
