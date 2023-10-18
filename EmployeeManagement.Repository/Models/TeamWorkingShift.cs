using System;
using System.Collections.Generic;

namespace EmployeeManagement.Repository.Models
{
    public partial class TeamWorkingShift
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public DateTime WorkShift { get; set; }
        public int ScheduleId { get; set; }

        public virtual Schedule Schedule { get; set; } = null!;
        public virtual Team Team { get; set; } = null!;
    }
}
