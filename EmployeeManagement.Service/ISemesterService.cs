using EmployeeManagement.Repository.Models;

namespace EmployeeManagement.Service
{
    public interface ISemesterService
    {
        Semester GetSemesterId(int Id);

        List<Semester> GetSemesterList();

        void DeleteSemester(int id);

        void UpdateSemester(Semester semester);
        void CreateSemester (Semester semester);
    }
}
