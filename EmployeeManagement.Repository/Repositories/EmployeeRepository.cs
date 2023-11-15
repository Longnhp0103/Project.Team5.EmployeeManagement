using EmployeeManagement.Repository.Models;
using Microsoft.EntityFrameworkCore;

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

        Employee IEmployeeRepository.GetEmployeeById(int id)
        {
            return _dbContext.Employees.Include(x => x.Team).FirstOrDefault(x => x.Id == id);
        }
    }
}
