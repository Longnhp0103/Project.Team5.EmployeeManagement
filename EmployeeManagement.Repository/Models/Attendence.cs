namespace EmployeeManagement.Repository.Models
{
    public partial class Attendence
    {
        public int Id { get; set; }
        public int Date { get; set; }
        public int Status { get; set; }
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; } = null!;
    }
}
