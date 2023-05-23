namespace EmployeeDepartmentAPI.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public int DepartmentID { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public Gender Gender { get; set; }
        public string Photopath { get; set; }
        public DateTime DateofBirth { get; set; }
        public Departments Department { get; set; }
       

    }
}
