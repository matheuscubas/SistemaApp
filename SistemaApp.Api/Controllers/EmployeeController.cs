using Microsoft.AspNetCore.Mvc;
using SistemaApp.Api.Validators;
using SistemaApp.Api.ViewModels;
using SistemaApp.Core.Data;
using SistemaApp.Core.Models;
using SistemaApp.Core.Repositories;
using Logger = Serilog.ILogger;

namespace SistemaApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly Logger _logger;
        private readonly EmployeeRepository _repository;

        public EmployeeController(Serilog.ILogger logger, EmployeeRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<ResultViewModel<Employee>>> CreateEmployee([FromBody] Employee model)
        {
            var result = new ResultViewModel<Employee>();
            var validator = new CreateEmployeeValidator();
            var validationResult = await validator.ValidateAsync(model);

            if (!validationResult.IsValid)
            {
                _logger.Information(validationResult.Errors.First().ToString());
                foreach (var error in validationResult.Errors)
                    result.Errors.Add(error.ToString());

                return BadRequest(result);
            }

            try
            {
                _repository.Create(model);
                _logger.Information($"The Employee {model.FirstName} was created sucessfully");
                result.Data = model;
                result.Sucess = true;
            }
            catch(Exception ex)
            {
                _logger.Warning(ex.Message);
                result.Errors.Add(ex.Message);
                return BadRequest(result);
            }

            return Ok(result);
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
        public async Task<ActionResult<ResultViewModel<PaginationResult<Employee>>>> GetPaginatedEmployees(
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
        public async Task<ActionResult<ResultViewModel<Employee>>> UpdateEmployee([FromBody] Employee model)
        {
            var result = new ResultViewModel<Employee>();
            var validator = new UpdateEmployeeValidator();
            var validationResult = await validator.ValidateAsync(model);

            if (!validationResult.IsValid)
            {
                foreach (var error in validationResult.Errors)
                {
                    _logger.Information(error.ToString());
                    result.Errors.Add(error.ToString());
                }
                return BadRequest(result);
            }

            try
            {
                _repository.Update(model);
                _logger.Information($"Employee {model.FirstName} updated successfully.");
                result.Data = await _repository.GetById((int)model.Id);
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

        [HttpDelete("[action]")]
        public async Task<ActionResult<ResultViewModel<Employee>>> DeleteEmployee(int id)
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
                _repository.DeleteAsync(id);
                result.Sucess = true;
                _logger.Information($"The Product {result.Data.FirstName} was deleted successfully.");
            }
            catch (Exception ex)
            {
                result.Errors.Add(ex.Message);
                result.Data = null;
                _logger.Warning(ex.Message);
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
