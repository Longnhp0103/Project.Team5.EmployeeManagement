namespace EmployeeManagement.Repository.Models
{
    public partial class Schedule
    {
        public Schedule()
        {
            TeamWorkingShifts = new HashSet<TeamWorkingShift>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime Shift { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<TeamWorkingShift> TeamWorkingShifts { get; set; }
    }
}
