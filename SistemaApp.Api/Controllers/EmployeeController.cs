using Microsoft.AspNetCore.Mvc;
using SistemaApp.Api.ViewModels;
using SistemaApp.Core.Data;
using SistemaApp.Core.Models;
using SistemaApp.Core.Repositories;
using System.Diagnostics.CodeAnalysis;
using Logger = Serilog.ILogger;

namespace SistemaApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly SistemaAppDbContext _context;
        private readonly Logger _logger;
        private readonly EmployeeRepository _repository;

        public EmployeeController(SistemaAppDbContext context, Serilog.ILogger logger, EmployeeRepository repository)
        {
            _context = context;
            _logger = logger;
            _repository = repository;
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<ResultViewModel<Employee>>> CreateEmployee()
        {
            return Ok();
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<ResultViewModel<Employee>>> GetEmployee(int id)
        {
            var result = new ResultViewModel<Employee>();

            if (id < 1)
            {
                result.Errors.Add($"The Id value must be grater than 0.");
                _logger.Warning("Id value must be grater than 0.");
                return BadRequest(result);
            }

            try
            {
                result.Data = await _repository.GetById(id);
                result.Sucess = true;
            }
            catch (Exception ex)
            {
                result.Errors.Add(ex.Message);
                _logger.Warning(ex.Message);
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<ResultViewModel<IEnumerable<Employee>>>> GetEmployees()
        {
            var result = new ResultViewModel<IEnumerable<Employee>>();

            try
            {
                result.Data = await _repository.GetAllAsync();
                result.Sucess = true;
                _logger.Information($"Returning {result.Data.Count()} Employees");
            }
            catch (Exception ex)
            {
                result.Errors.Add(ex.Message);
                _logger.Warning(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, result);
            }

            return Ok(result);
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<ResultViewModel<PaginationResult<Employee>>>> GetPaginatedCustomer(
            [FromQuery] int pageSize = 5,
            [FromQuery] int pageNumber = 1)
        {
            var result = new ResultViewModel<PaginationResult<Employee>>();

            if (pageSize < 1 || pageNumber < 1)
            {
                result.Errors.Add("The pageNumber and pageSize must be grater than 0.");
                _logger.Information("The pageNumber and pageSize must be grater than 0.");
                return BadRequest(result);
            }
            try
            {
                result.Data = await _repository.GetPaginated(pageSize, pageNumber);
                result.Sucess = true;
                _logger.Information($"Returning {result.Data.Items.Count()} Employees");
            }
            catch (Exception ex)
            {
                result.Errors.Add(ex.Message);
                _logger.Information(ex.Message);
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpPut("[action]")]
        public async Task<ActionResult<ResultViewModel<Customer>>> UpdateCustomer()
        {
            return Ok();
        }

        [HttpDelete("[action]")]
        public async Task<ActionResult<ResultViewModel<Customer>>> DeleteCustomer()
        {
            return Ok();
        }
    }
}
