using Microsoft.AspNetCore.Mvc;
using SistemaApp.Api.Validators;
using SistemaApp.Api.ViewModels;
using SistemaApp.Core.Data;
using SistemaApp.Core.Dtos;
using SistemaApp.Core.Models;
using SistemaApp.Core.Repositories;
using Logger = Serilog.ILogger;

namespace SistemaApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly Logger _logger;
        private readonly CustomerRepository _repository;

        public CustomerController(Logger logger, CustomerRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<ResultViewModel<Customer>>> CreateCustomer([FromBody] CreateCustomerDto model)
        {
            var result = new ResultViewModel<Customer>();
            var validator = new CreateCustomerValidator();
            var validationResult = await validator.ValidateAsync(model);

            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors;
                _logger.Information(errors.First().ErrorMessage);
                foreach (var error in errors)
                    result.Errors.Add(error.ToString());
                return BadRequest(result);
            }

            try
            {
                result.Data = await _repository.CreateCustomerAsync(model);
                result.Sucess = true;
                _logger.Information($"Customer {result.Data.Name} created successfully");
            }
            catch(Exception ex)
            {
                result.Errors.Add(ex.Message);
                _logger.Warning(ex.Message);
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<ResultViewModel<Customer>>> GetCustomer(int id)
        {
            var result = new ResultViewModel<Customer>();

            if(id < 1)
            {
                result.Errors.Add("The Id value must be grater than 0.");
                _logger.Information("The Id value must be grater than 0.");
                return BadRequest(result);
            }

            try
            {
                var customer = await _repository.GetById(id);
                result.Data = customer;
                result.Sucess = true;
            }
            catch(Exception ex)
            {
                result.Errors.Add(ex.Message);
                _logger.Information(ex.Message);
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<ResultViewModel<IEnumerable<Customer>>>> GetAllCustomers()
        {
            var result = new ResultViewModel<IEnumerable<Customer>>();

            try
            {
                var customers = await _repository.GetAllAsync();
                result.Data = customers;
                result.Sucess = true;
                _logger.Information($"returning {customers.Count()} customers");
            }
            catch(Exception ex)
            {
                result.Errors.Add(ex.Message);
                _logger.Warning(ex.Message);
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<ResultViewModel<PaginationResult<Customer>>>> GetPaginetedCustomers(
            [FromQuery] int pageSize = 5,
            [FromQuery] int pageNumber =1)
        {
            var result = new ResultViewModel<PaginationResult<Customer>>();

            if (pageSize < 1 || pageNumber < 1)
            {
                result.Errors.Add("The pageNumber and pageSize must be grater than 0.");
                _logger.Information("The pageNumber and pageSize must be grater than 0.");
                return BadRequest(result);
            }
            try
            {
                var paginatedCategories = await _repository.GetPaginated(pageSize, pageNumber);
                result.Data = paginatedCategories;
                result.Sucess = true;
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
        public async Task<ActionResult<ResultViewModel<Customer>>> UpdateCustomer(Customer model)
        {
            var result = new ResultViewModel<Customer>();
            var validator = new UpdateCustomerValidator();
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
                _logger.Information($"Customer {model.Name} updated successfully.");
                result.Data = await _repository.GetById(model.Id);
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
        public async Task<ActionResult<ResultViewModel<Customer>>> DeleteCustomer(int id)
        {
            var result = new ResultViewModel<Customer>();

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
                _logger.Information($"The Category {result.Data.Name} was deleted successfully.");
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
