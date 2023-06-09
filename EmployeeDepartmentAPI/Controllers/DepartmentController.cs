using EmployeeDepartmentAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDepartmentAPI.Controllers
{

    [ApiController]
    [Route("[Controller")]
    public class DepartmentController:ControllerBase
    {
        private readonly IDepartmentRepository departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }


    }
}
