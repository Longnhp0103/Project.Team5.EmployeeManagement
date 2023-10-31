namespace EmployeeManagement.Repository.Models
{
    public partial class Team
    {
        public Team()
        {
            Employees = new HashSet<Employee>();
            ProjectsOfTeams = new HashSet<ProjectsOfTeam>();
            TeamWorkingShifts = new HashSet<TeamWorkingShift>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int MemberNumber { get; set; }
        public bool Status { get; set; }
        public DateTime Ojttime { get; set; }
        public int SemesterId { get; set; }
        public int Leader { get; set; }

        public virtual Semester Semester { get; set; } = null!;
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<ProjectsOfTeam> ProjectsOfTeams { get; set; }
        public virtual ICollection<TeamWorkingShift> TeamWorkingShifts { get; set; }
    }
}
