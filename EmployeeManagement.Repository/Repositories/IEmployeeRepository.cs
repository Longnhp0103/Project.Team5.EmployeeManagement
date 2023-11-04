using EmployeeManagement.Repository.Models;

namespace EmployeeManagement.Repository.Repositories
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        public Employee Authentication( string email, string password );
    }
}
