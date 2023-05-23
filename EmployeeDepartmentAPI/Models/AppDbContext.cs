using Microsoft.EntityFrameworkCore;

namespace EmployeeDepartmentAPI.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions):base(dbContextOptions)
        {


        }

        public DbSet<Employee> Employeesdb { get; set; }
        public DbSet<Departments> Departmentsdb { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Departments>().HasData(new Departments { DepartmentID = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Departments>().HasData(new Departments { DepartmentID = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Departments>().HasData(new Departments { DepartmentID = 3, DepartmentName = "Security" });
            modelBuilder.Entity<Departments>().HasData(new Departments { DepartmentID = 4, DepartmentName = "Finance" });

            modelBuilder.Entity<Employee>().HasData(new Employee { DateofBirth = DateTime.Now,
            DepartmentID =1,EmployeeID=1,FirstName="samikshya1",Lastname="Kar",Gender=Gender.Female
            
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                DateofBirth = DateTime.Now,
                DepartmentID = 1,
                EmployeeID = 2,
                FirstName = "samikshya2",
                Lastname = "Kar",
                Gender = Gender.Female

            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                DateofBirth = DateTime.Now,
                DepartmentID = 2,
                EmployeeID = 2,
                FirstName = "samikshya3",
                Lastname = "Kar",
                Gender = Gender.Male

            });
        }

       

    }
}
