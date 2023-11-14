using EmployeeManagement.Repository.Models;

namespace EmployeeManagement.Service
{
    public interface IProjectService
    {
        Project GetProjectId(int Id);
        void CreateProject(Project project);
        List<Project> GetAllProjects();
        void DeleteProject(int Id);
        void UpgradeProject(Project project);
    }
}
