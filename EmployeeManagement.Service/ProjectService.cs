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

        public void CreateProject(Project project)
        {
            repository.Insert(project);
        }

        public void DeleteProject(int Id)
        {
            Project project = repository.GetById(Id);
            if (project != null)
            {
                repository.Delete(project.Id);
            }
        }

        public List<Project> GetAllProjects()
        {
            return(List<Project>)repository.GetAll();
        }

        public Project GetProjectId(int Id)
        {
            Project projectId = repository.GetById(Id); 
            return projectId;
        }

        public void UpgradeProject(Project project)
        {
            repository.Update(project);
        }
    }
}
