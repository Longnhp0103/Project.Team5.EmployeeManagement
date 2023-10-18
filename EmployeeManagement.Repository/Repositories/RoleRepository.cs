using EmployeeManagement.Repository.Models;

namespace EmployeeManagement.Repository.Repositories
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        public RoleRepository(EmployeeManagementContext dbContext) : base(dbContext)
        {
        }
    }
}
