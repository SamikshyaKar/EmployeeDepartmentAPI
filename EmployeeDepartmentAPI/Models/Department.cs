using System.ComponentModel.DataAnnotations;

namespace EmployeeDepartmentAPI.Models
{
    public class Department
    {
        //[Key]
        public int DepartmentID { get; set; }
        [MaxLength(10, ErrorMessage = "DepartmentName Requires at max 10 characters")]
        [MinLength(2, ErrorMessage = "DepartmentName Requires at Least 2 characters")]
        public string DepartmentName { get; set; }=string.Empty;

    }
}
