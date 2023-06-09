using EmployeeDepartmentAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDepartmentAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllEmployeesList()
        {
            var result = await employeeRepository.GetAllEmployee();

            if (result != null) return Ok(result);
            else return BadRequest();
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var result = await employeeRepository.GetEmployeeById(id);
            if (result != null) return Ok(result);
            else return BadRequest();
        }

        [HttpGet("EmployeeName")]
        public async Task<IActionResult> GetEmployeebyName(string employeebyName)
        {
            try
            {
                //var result = await employeeRepository.GetEmployeeByName(employeebyName.ToLower().ToString());
                //if (result != null) return Ok(result);
                return Ok(await employeeRepository.GetEmployeeByName(employeebyName.ToLower().ToString()));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving from database");
            }


        }


    }
}
