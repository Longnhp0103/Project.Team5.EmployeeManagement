using EmployeeManagement.Repository.Models;
using EmployeeManagement.Repository.Repositories;

namespace EmployeeManagement.Service
{
    public class ProjectService : IProjectService
    {
        IProjectRepository repository;
        public ProjectService(IProjectRepository repository)
        {
            this.repository = repository;
        }
        public Project GetProjectId(int Id)
        {
            Project projectId = repository.GetById(Id); 
            return projectId;
        }
    }
}
