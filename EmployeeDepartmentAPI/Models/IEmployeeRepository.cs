namespace EmployeeDepartmentAPI.Models
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetEmployeeById(int empid);
        Task<Employee> GetEmployeeByName(string name);
        Task<Employee> GetEmployeeByEmail(string email);
        Task<Employee> CreateEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);
        Task<IEnumerable<Employee>> GetAllEmployee();
        Task DeleteEmployee(int empid);

        Task<IEnumerable<Employee>> SearchEmployee(string name, Gender? gender);


    }
}
