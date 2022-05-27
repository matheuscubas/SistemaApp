using Microsoft.AspNetCore.Mvc;
using SistemaApp.Api.Validators;
using SistemaApp.Api.ViewModels;
using SistemaApp.Core.Data;
using SistemaApp.Core.Models;
using SistemaApp.Core.Repositories;
using Logger = Serilog.ILogger;

namespace SistemaApp.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository _repository;
        private readonly Logger _logger;

        public ProductController(ProductRepository repository, Serilog.ILogger logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult<ResultViewModel<Product>>> CreateProduct([FromBody] Product model)
        {
            var result = new ResultViewModel<Product>();
            var validator = new CreateProductValidator();
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
                _logger.Information($"The Product {model.Name} was created sucessfully");
                result.Data = model;
                result.Sucess = true;
            }
            catch (Exception ex)
            {
                _logger.Warning(ex.Message);
                result.Errors.Add(ex.Message);
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<ResultViewModel<Product>>> GetProduct(int id)
        {
            var result = new ResultViewModel<Product>();

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

        [HttpGet]
        public async Task<ActionResult<ResultViewModel<IEnumerable<Product>>>> GetAllProducts()
        {
            var result = new ResultViewModel<IEnumerable<Product>>();

            try
            {
                result.Data = await _repository.GetAllAsync();
                result.Sucess = true;
                _logger.Information($"Returning {result.Data.Count()} Products");
            }
            catch (Exception ex)
            {
                result.Errors.Add(ex.Message);
                _logger.Warning(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, result);
            }

            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<ResultViewModel<PaginationResult<Product>>>> GetPaginatedProducts(
            [FromQuery] int pageSize = 5,
            [FromQuery] int pageNumber = 1)
        {
            var result = new ResultViewModel<PaginationResult<Product>>();

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
                _logger.Information($"Returning {result.Data.Items.Count()} Products");
            }
            catch (Exception ex)
            {
                result.Errors.Add(ex.Message);
                _logger.Information(ex.Message);
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<ResultViewModel<Product>>> UpdateProduct([FromBody] Product model)
        {
            var result = new ResultViewModel<Product>();
            var validator = new UpdateProductValidator();
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
                _logger.Information($"Product {model.Name} updated successfully.");
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

        [HttpDelete]
        public async Task<ActionResult<ResultViewModel<Product>>> DeleteProduct(int id)
        {
            var result = new ResultViewModel<Product>();

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
                _logger.Information($"The Product {result.Data.Name} was deleted successfully.");
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
