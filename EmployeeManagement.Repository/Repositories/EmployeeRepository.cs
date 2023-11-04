using EmployeeManagement.Repository.Models;

namespace EmployeeManagement.Repository.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeManagementContext dbContext) : base(dbContext)
        {
        }

        Employee IEmployeeRepository.Authentication(string email, string password)
        {
            return _dbContext.Employees.FirstOrDefault(x => x.Email == email && x.Password == password);
        }
    }
}
