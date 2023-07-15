using Microsoft.EntityFrameworkCore;

namespace EmployeeDepartmentAPI.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext appDbContext;

        public EmployeeRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<Employee> CreateEmployee(Employee employee)
        {
            if (employee.Department != null)
            {
                appDbContext.Entry(employee.Department).State = EntityState.Unchanged;
            }

            var result = await appDbContext.Employeesdb.AddAsync(employee);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteEmployee(int empid)
        {
            var result = await appDbContext.Employeesdb.FirstOrDefaultAsync(e => e.EmployeeID == empid);
            if (result != null)
            {
                appDbContext.Employeesdb.Remove(result);
                appDbContext.SaveChanges();
            }
        }

        public async Task<IEnumerable<Employee>> GetAllEmployee()
        {
            return await appDbContext.Employeesdb.ToListAsync();
        }

        public Task<Employee> GetEmployeeByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<Employee?> GetEmployeeById(int empid)
        {
            return await appDbContext.Employeesdb.Include(e => e.Department)
                  .FirstOrDefaultAsync(e => e.EmployeeID == empid);
        }

        public async Task<Employee?> GetEmployeeByName(string fname)
        {
            return await appDbContext.Employeesdb.Include(e => e.Department)
                   .FirstOrDefaultAsync(e => e.FirstName == fname);
        }

        public async Task<IEnumerable<Employee>> SearchEmployee(string name, Gender? gender)
        {
            IQueryable<Employee> employeesequery = appDbContext.Employeesdb;
            if (!string.IsNullOrEmpty(name))
            {
               employeesequery=employeesequery.Where(e => e.FirstName.Contains(name) || e.Lastname.Contains(name));                   

            }

            if(gender != null)
            {
                employeesequery=employeesequery.Where(e => e.Gender == gender);
            }


            return await employeesequery.ToListAsync();


        }

        public async Task<Employee?> UpdateEmployee(Employee employee)
        {
            var result = await appDbContext.Employeesdb.FirstOrDefaultAsync(e => e.EmployeeID == employee.EmployeeID);
            if (result != null)
            {
                result.FirstName=employee.FirstName;
                result.Lastname = employee.Lastname;
                result.Gender=employee.Gender;
                result.DateofBirth=employee.DateofBirth;
                result.Photopath=employee.Photopath;
                result.DepartmentID=employee.DepartmentID;
                result.Department=employee.Department;


                await appDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
