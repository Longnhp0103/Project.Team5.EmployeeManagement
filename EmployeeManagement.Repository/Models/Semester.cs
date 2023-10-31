namespace EmployeeManagement.Repository.Models
{
    public partial class Semester
    {
        public Semester()
        {
            StudentOfSemesters = new HashSet<StudentOfSemester>();
            Teams = new HashSet<Team>();
        }

        public int Id { get; set; }
        public int Year { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<StudentOfSemester> StudentOfSemesters { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
