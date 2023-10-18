using EmployeeManagement.Repository.Models;

namespace EmployeeManagement.Repository.Repositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(EmployeeManagementContext dbContext) : base(dbContext)
        {
        }
    }
}
