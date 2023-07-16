﻿using EmployeeDepartmentAPI.Models;
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
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Employee>> GetEmployeeByEmpID(int id)
        {
            try
            {
                //return Ok(await employeeRepository.GetEmployeeById(id));

                var result = await employeeRepository.GetEmployeeById(id);

                if (result != null) return Ok(result);

                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving from database");
            }

        }

        [HttpGet("{empid}")]
        public async Task<ActionResult<Employee>> GetEmployeeByEmpIDs(int empid)
        {
            try
            {
                //return Ok(await employeeRepository.GetEmployeeById(id));

                var result = await employeeRepository.GetEmployeeById(empid);

                if (result == null) return NotFound();
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving from database");
            }

        }


        [HttpPost]
        public async Task<ActionResult<Employee>> CreateEmployee(Employee employee)
        {
            try
            {
                if (employee == null)
                    return BadRequest();
                Employee? emp = await employeeRepository.GetEmployeeByEmail(employee.Email);
                if (emp != null)
                {
                    ModelState.AddModelError("Email", "Employee is already in Use");
                    return BadRequest(ModelState);

                }
                var result = await employeeRepository.CreateEmployee(employee);


                return CreatedAtAction(nameof(GetEmployeeByEmpID), new { id = result.EmployeeID }, result);


            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error Creating Employee");
            }

        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteEmployee(int id)
        {

            try
            {
                var deletedemployee = await employeeRepository.GetEmployeeById(id);
                if (deletedemployee == null) return NotFound($"Employee with ID= {id} not found");

                await employeeRepository.DeleteEmployee(id);
                return Ok($"Employee with ID={id} is deleted successfully");



            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error in deleting employee");
            }
        }


        [HttpPut("{id:int}")]
        public async Task<ActionResult<Employee>> UpdateEmployee(int id, Employee employee)
        {
            try
            {
                if (id != employee.EmployeeID)
                {
                    return BadRequest("Employee ID mismatch");
                }
                var employeetobeUpdated = await employeeRepository.GetEmployeeById(id);
                if (employeetobeUpdated == null) return NotFound($"Employee with ID={id} not found");

                return await employeeRepository.UpdateEmployee(employee);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error in updating Employee");
            }
        }




    }
}
