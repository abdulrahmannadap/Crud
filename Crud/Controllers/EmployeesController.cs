using AutoMapper;
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

    }
}
