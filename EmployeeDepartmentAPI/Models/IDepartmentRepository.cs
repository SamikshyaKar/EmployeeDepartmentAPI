namespace EmployeeDepartmentAPI.Models
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetAllDepartments();
        Task<Department> GetDepartments(int departmentId);
    }
}
