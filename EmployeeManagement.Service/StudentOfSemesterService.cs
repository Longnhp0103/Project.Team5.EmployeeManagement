using EmployeeManagement.Repository.Models;
using EmployeeManagement.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Service
{
    public class StudentOfSemesterService : IStudentOfSemesterService
    {
        IStudentOfSemesterRepository repository;
        public StudentOfSemesterService(IStudentOfSemesterRepository repository)
        {
            this.repository = repository;
        }
        public void CreateStudentOfSemesterService(StudentOfSemester studentOfSemester)
        {
            repository.Insert(studentOfSemester);
        }

        public void DeleteStudentOfSemester(int semesterId)
        {
            StudentOfSemester studentOfSemester = repository.GetById(semesterId);
            if(studentOfSemester != null)
            {
                repository.Delete(studentOfSemester.Id);
            }
        }

        public StudentOfSemester GetStudentOfSemesterId(int id)
        {
            return repository.GetById(id);
        }

        public List<StudentOfSemester> GetStudentOfSemesterList()
        {
            return(List<StudentOfSemester>)repository.GetAll();
        }

        public void UpdateStudentOfSemester(StudentOfSemester studentOfSemester)
        {
            repository.Update(studentOfSemester);
        }
    }
}
