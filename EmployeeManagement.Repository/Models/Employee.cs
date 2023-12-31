﻿using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Repository.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Attendences = new HashSet<Attendence>();
            EmployeeWorkingShifts = new HashSet<EmployeeWorkingShift>();
            StudentOfSemesters = new HashSet<StudentOfSemester>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Address { get; set; }
        public bool Gender { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; } = null!;
        public DateTime Birthday { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool Status { get; set; }
        public int RoleId { get; set; }
        public int TeamId { get; set; }

        public virtual Role Role { get; set; } = null!;
        public virtual Team Team { get; set; } = null!;
        public virtual ICollection<Attendence> Attendences { get; set; }
        public virtual ICollection<EmployeeWorkingShift> EmployeeWorkingShifts { get; set; }
        public virtual ICollection<StudentOfSemester> StudentOfSemesters { get; set; }
        [NotMapped] public bool isAdmin { get; set; }
    }
}
