namespace EmployeeManagement.Repository.Models
{
    public partial class Project
    {
        public Project()
        {
            ProjectsOfTeams = new HashSet<ProjectsOfTeam>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<ProjectsOfTeam> ProjectsOfTeams { get; set; }
    }
}
