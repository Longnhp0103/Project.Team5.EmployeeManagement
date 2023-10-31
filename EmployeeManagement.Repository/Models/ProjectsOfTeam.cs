namespace EmployeeManagement.Repository.Models
{
    public partial class ProjectsOfTeam
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int TeamId { get; set; }

        public virtual Team Project { get; set; } = null!;
        public virtual Project Team { get; set; } = null!;
    }
}
