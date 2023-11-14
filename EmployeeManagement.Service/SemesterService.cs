using EmployeeManagement.Repository.Models;
using EmployeeManagement.Repository.Repositories;

namespace EmployeeManagement.Service
{
    public class SemesterService : ISemesterService
    {
        ISemesterRepository repository;
        public SemesterService(ISemesterRepository repository)
        {
            this.repository = repository;
        }

        public Semester GetSemesterId(int Id)
        {
            Semester semesterId = repository.GetById(Id); ;

            return semesterId;
        }
    }
}
