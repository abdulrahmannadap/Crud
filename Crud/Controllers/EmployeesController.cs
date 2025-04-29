using AutoMapper;
using Crud.Dtos;
using Crud.Entities;
using Crud.Services;
using Microsoft.AspNetCore.Mvc;

namespace Crud.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EmployeesController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        /// <summary>
        /// Creates a new employee from Angular form submission.
        /// </summary>
        /// <param name="employeeDto">Employee data from Angular</param>
        /// <returns>Action result</returns>
        [HttpPost]
        public async Task<IActionResult> CreateEmployee([FromBody] EmployeeCreateDto employeeDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var employee = _mapper.Map<Employee>(employeeDto);

            // Optional: set audit fields here
            employee.CreatedBy = "AngularClient"; // or retrieve from claims
            employee.CreatedDate = DateTime.UtcNow;

            await _unitOfWork.EmployeeRepo.AddAsync(employee);
            await _unitOfWork.CompleteAsync();

            return Ok(new { message = "Employee created successfully." });
        }
    }
}
