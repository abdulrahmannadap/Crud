using AutoMapper;
using Crud.Dtos;
using Crud.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IMapper _mapper;
        public EmployeesController(IMapper mapper)
        {
            _mapper = mapper;
        }
        // POST: api/employee
        [HttpPost]
        public IActionResult CreateEmployee([FromBody] EmployeeCreateDto employeeCreateDto)
        {
            if (employeeCreateDto == null)
            {
                return BadRequest("Employee data is required.");
            }

            // Map DTO to Employee model
            var employee = _mapper.Map<Employee>(employeeCreateDto);

            // You can now save the employee data to the database
            // Example: Save to a database (code omitted for simplicity)

            // Returning a success response with the employee data
            return Ok(new { message = "Employee created successfully", employee });
        }
    }
}
