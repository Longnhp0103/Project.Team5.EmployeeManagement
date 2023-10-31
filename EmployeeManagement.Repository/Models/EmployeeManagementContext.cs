using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EmployeeManagement.Repository.Models
{
    public partial class EmployeeManagementContext : DbContext
    {
        public EmployeeManagementContext()
        {
        }

        public EmployeeManagementContext(DbContextOptions<EmployeeManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attendence> Attendences { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeeWorkingShift> EmployeeWorkingShifts { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<ProjectsOfTeam> ProjectsOfTeams { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Schedule> Schedules { get; set; } = null!;
        public virtual DbSet<Semester> Semesters { get; set; } = null!;
        public virtual DbSet<StudentOfSemester> StudentOfSemesters { get; set; } = null!;
        public virtual DbSet<Team> Teams { get; set; } = null!;
        public virtual DbSet<TeamWorkingShift> TeamWorkingShifts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GetConnectionString());
        }

        public string GetConnectionString()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration configuration = builder.Build();
            return configuration.GetConnectionString("DefaultConnection");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendence>(entity =>
            {
                entity.ToTable("Attendence");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Attendences)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKAttendence346664");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.HasIndex(e => e.Email, "UQ__Employee__A9D1053404FF1AC4")
                    .IsUnique();

                entity.HasIndex(e => e.UserName, "UQ__Employee__C9F28456EB2BFA18")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKEmployee880724");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKEmployee127959");
            });

            modelBuilder.Entity<EmployeeWorkingShift>(entity =>
            {
                entity.ToTable("EmployeeWorkingShift");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeWorkingShifts)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKEmployeeWo370142");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("Project");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProjectsOfTeam>(entity =>
            {
                entity.ToTable("ProjectsOfTeam");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectsOfTeams)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKProjectsOf938199");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.ProjectsOfTeams)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKProjectsOf305398");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.ToTable("Schedule");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Shift).HasColumnType("date");
            });

            modelBuilder.Entity<Semester>(entity =>
            {
                entity.ToTable("Semester");
            });

            modelBuilder.Entity<StudentOfSemester>(entity =>
            {
                entity.ToTable("StudentOfSemester");

                entity.Property(e => e.StudentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.StudentOfSemesters)
                    .HasForeignKey(d => d.SemesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKStudentOfS270568");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentOfSemesters)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKStudentOfS839173");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("Team");

                entity.HasIndex(e => e.Name, "UQ__Team__737584F6CDC7D89C")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ojttime)
                    .HasColumnType("date")
                    .HasColumnName("OJTTime");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.SemesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKTeam141105");
            });

            modelBuilder.Entity<TeamWorkingShift>(entity =>
            {
                entity.ToTable("TeamWorkingShift");

                entity.Property(e => e.WorkShift).HasColumnType("date");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.TeamWorkingShifts)
                    .HasForeignKey(d => d.ScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKTeamWorkin232499");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.TeamWorkingShifts)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKTeamWorkin363391");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
