namespace EmployeeManagement.Repository.Models
{
    public partial class EmployeeWorkingShift
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; } = null!;
        public DateTime Date { get; set; }
        public bool Status { get; set; }

        public virtual Employee Employee { get; set; } = null!;
    }
}
