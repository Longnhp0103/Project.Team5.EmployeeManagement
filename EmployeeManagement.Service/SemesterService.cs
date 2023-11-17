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

        public void CreateSemester(Semester semester)
        {
            repository.Insert(semester);
        }

        public void DeleteSemester(int id)
        {
           Semester semester = repository.GetById(id);
            if(semester != null)
            {
                repository.Delete(semester.Id);
            }
        }

        public Semester GetSemesterId(int Id)
        {
            Semester semesterId = repository.GetById(Id); ;

            return semesterId;
        }

        public List<Semester> GetSemesterList()
        {
            return(List<Semester>)repository.GetAll();
        }

        public void UpdateSemester(Semester semester)
        {
           repository.Update(semester);
        }
    }
}
