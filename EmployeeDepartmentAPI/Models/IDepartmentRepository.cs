namespace EmployeeDepartmentAPI.Models
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Departments>> GetAllDepartments();
        Task<Departments> GetDepartments(int departmentId);
    }
}
