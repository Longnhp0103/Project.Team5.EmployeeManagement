using EmployeeManagement.Repository.Models;

namespace EmployeeManagement.Repository.Repositories
{
    public class EmployeeWorkingShiftRepository : GenericRepository<EmployeeWorkingShift>, IEmployeeWorkingShiftRepository
    {
        public EmployeeWorkingShiftRepository(EmployeeManagementContext dbContext) : base(dbContext)
        {
        }
    }
}
