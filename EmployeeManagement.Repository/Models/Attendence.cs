namespace EmployeeManagement.Repository.Models
{
    public partial class Attendence
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }
        public string EmployeeId { get; set; } = null!;

        public virtual Employee Employee { get; set; } = null!;
    }
}
