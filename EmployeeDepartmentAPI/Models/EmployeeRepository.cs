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

        public Task<IEnumerable<Employee>> GetAllEmployee()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeById(int empid)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeByName(string name)
        {
            throw new NotImplementedException();
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
