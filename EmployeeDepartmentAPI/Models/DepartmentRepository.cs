using Microsoft.EntityFrameworkCore;

namespace EmployeeDepartmentAPI.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext appDbContext;

        public DepartmentRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<IEnumerable<Department>> GetAllDepartments()
        {
            return await appDbContext.Departmentsdb.ToListAsync();
        }

        public async Task<Department> GetDepartments(int departmentId)
        {
            var result= await appDbContext.Departmentsdb.FirstOrDefaultAsync(d=>d.DepartmentID==departmentId);
            return result;
        }
    }
}
