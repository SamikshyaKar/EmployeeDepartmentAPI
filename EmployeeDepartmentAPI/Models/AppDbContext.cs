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
            DepartmentID =1,EmployeeID=1111,FirstName="samikshya1",Lastname="Kar",Gender=Gender.Female,
            Photopath= "Img/Flower1.jpg"

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                DateofBirth = DateTime.Now,
                DepartmentID = 1,
                EmployeeID = 1112,
                FirstName = "samikshya2",
                Lastname = "Kar",
                Gender = Gender.Female,
                Photopath= "Img/Flower1.jpg"

            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                DateofBirth = DateTime.Now,
                DepartmentID = 2,
                EmployeeID = 1113,
                FirstName = "samikshya3",
                Lastname = "Kar",
                Gender = Gender.Male,
                Photopath= "Img/Flower2.jpg"

            });
        }

       

    }
}
