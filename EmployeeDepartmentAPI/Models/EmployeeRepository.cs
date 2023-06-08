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
          var result= await appDbContext.Employeesdb.AddAsync(employee);
                      await appDbContext.SaveChangesAsync();
                      return result.Entity;
        }

        public async Task DeleteEmployee(int empid)
        {
            var result = await appDbContext.Employeesdb.FirstOrDefaultAsync(e => e.EmployeeID == empid);
            if(result !=null)
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

        public Task<IEnumerable<Employee>> SearchEmployee(string name, Gender? gender)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
