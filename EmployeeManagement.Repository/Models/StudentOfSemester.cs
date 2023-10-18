using System;
using System.Collections.Generic;

namespace EmployeeManagement.Repository.Models
{
    public partial class StudentOfSemester
    {
        public int Id { get; set; }
        public int SemesterId { get; set; }
        public int StudentId { get; set; }

        public virtual Semester Semester { get; set; } = null!;
        public virtual Employee Student { get; set; } = null!;
    }
}
