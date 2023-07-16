using System.ComponentModel.DataAnnotations;

namespace EmployeeDepartmentAPI.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public int DepartmentID { get; set; }
        [MaxLength(18, ErrorMessage = "First Name Requires at max 18 characters")]
        [MinLength(2,ErrorMessage ="First Name Requires at Least 2 characters")]
        public string FirstName { get; set; }= string.Empty;
        [MaxLength(10, ErrorMessage = "Last Name Requires at max 10 characters")]
        [MinLength(2, ErrorMessage = "Last Name Requires at Least 2 characters")]
        public string Lastname { get; set; } = string.Empty;
        public Gender Gender { get; set; }=Gender.Female;
        public string Photopath { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime DateofBirth { get; set; }
        public Department Department { get; set; }
       

    }
}
