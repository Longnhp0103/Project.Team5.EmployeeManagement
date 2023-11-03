using EmployeeManagement.Repository.Models;
using EmployeeManagement.Repository.Repositories;

namespace EmployeeManagement.Service
{
    public class RoleService : IRoleService
    {
        IRoleRepository roleRepository;
        public RoleService(IRoleRepository roleRepository)
        {
            this.roleRepository = roleRepository;
        }
        public Role GetStaffAccount(int id)
        {
            Role staffAccount = roleRepository.GetById(id);
            return staffAccount;
        }
    }
}
