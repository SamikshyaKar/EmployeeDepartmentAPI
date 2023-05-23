using System.ComponentModel.DataAnnotations;

namespace EmployeeDepartmentAPI.Models
{
    public class Departments
    {
        [Key]
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

    }
}
