using EmployeeDepartmentAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDepartmentAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EmployeeController:ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }



    }
}
