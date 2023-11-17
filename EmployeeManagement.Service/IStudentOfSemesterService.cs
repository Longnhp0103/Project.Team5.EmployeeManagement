using EmployeeManagement.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Service
{
    public interface IStudentOfSemesterService
    {
        void CreateStudentOfSemesterService(StudentOfSemester studentOfSemester);
        List<StudentOfSemester> GetStudentOfSemesterList();
        void UpdateStudentOfSemester(StudentOfSemester studentOfSemester);
        void DeleteStudentOfSemester(int semesterId);
        StudentOfSemester GetStudentOfSemesterId(int id);
    }
}
