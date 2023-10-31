namespace EmployeeManagement.Repository.Models
{
    public partial class StudentOfSemester
    {
        public int Id { get; set; }
        public int SemesterId { get; set; }
        public string StudentId { get; set; } = null!;

        public virtual Semester Semester { get; set; } = null!;
        public virtual Employee Student { get; set; } = null!;
    }
}
