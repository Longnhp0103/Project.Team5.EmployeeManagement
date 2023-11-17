using EmployeeManagement.Repository.Models;
using EmployeeManagement.Repository.Repositories;
using System.Collections.Generic;

namespace EmployeeManagement.Service
{
    public class EmployeeWorkingShiftService : IEmployeeWorkingShiftService
    {
        IEmployeeWorkingShiftRepository repository;
        public EmployeeWorkingShiftService(IEmployeeWorkingShiftRepository repository)
        {
            this.repository = repository;
        }

        public void CreateEmployeeWorkingShift(EmployeeWorkingShift employeeWorkingShift)
        {
            repository.Insert(employeeWorkingShift);
        }

        public void DeleteEmployeeWorkingShift(int id)
        {
            EmployeeWorkingShift employeeWorkingShift = repository.GetById(id);
            if (employeeWorkingShift != null )
            {
                repository.Delete(employeeWorkingShift.Id);
            }
        }

        public List<EmployeeWorkingShift> GetAll()
        {
           return(List<EmployeeWorkingShift>)repository.GetAll();
        }

        public EmployeeWorkingShift GetEmployeeWorkingShiftId(int id)
        {
            EmployeeWorkingShift employeeWorkingShiftId = repository.GetById(id);
            return employeeWorkingShiftId;
        }

        public void UpdateEmployeeWorkingShift(EmployeeWorkingShift employeeWorkingShift)
        {
            repository.Update(employeeWorkingShift);
        }
    }
}
