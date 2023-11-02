namespace EmployeeManagement.Repository.Models
{
    public partial class EmployeeWorkingShift
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }

        public virtual Employee Employee { get; set; } = null!;
    }
}
