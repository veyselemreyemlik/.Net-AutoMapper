using AutoMapper;
using LastDance.Data;
using LastDance.Dtos;
using LastDance.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LastDance.Controllers
{
    [Route("api/[controller]")]

    [ApiController]

    public class EmployeeController : ControllerBase

    {

        private readonly AppDbContext

            _appDbContext;

        private readonly IMapper _mapper;



        public EmployeeController(AppDbContext appDbContext, IMapper mapper)

        {

            _appDbContext = appDbContext;

            _mapper = mapper;

        }



        [HttpGet]

        public async Task<ActionResult<List<ResponseDTO>>> GetEmployees()

        {

            var employees = await

                _appDbContext.Employees.ToListAsync();

            return Ok(employees.Select(_mapper.Map<ResponseDTO>));

        }





        [HttpPost]

        public async Task<ActionResult<List<ResponseDTO>>> AddEmployee(RequestDTO newEmployee)

        {

            var employee = _mapper.Map<Employee>(newEmployee);

            _appDbContext.Employees.Add(employee);

            await _appDbContext.SaveChangesAsync();



            var employees = await _appDbContext.Employees.ToListAsync();

            return Ok(employees.Select(_mapper.Map<ResponseDTO>));

        }

    }
}
