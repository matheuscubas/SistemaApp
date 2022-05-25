using Microsoft.AspNetCore.Mvc;
using SistemaApp.Api.Validators;
using SistemaApp.Api.ViewModels;
using SistemaApp.Core.Data;
using SistemaApp.Core.Models;
using SistemaApp.Core.Repositories;
using Logger = Serilog.ILogger;

namespace SistemaApp.Api.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository _repository;
        private readonly SistemaAppDbContext _context;
        private readonly Logger _logger;

        public ProductController(ProductRepository repository, SistemaAppDbContext context, Serilog.ILogger logger)
        {
            _repository = repository;
            _context = context;
            _logger = logger;
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<ResultViewModel<Product>>> CreateProdut([FromBody] Product model)
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

        [HttpGet("[action]")]
        public async Task<ActionResult<ResultViewModel<Product>>> GetProduct(int id)
        {
            return Ok();
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<ResultViewModel<IEnumerable<Product>>>> GetAllProducts()
        {
            return Ok();
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<ResultViewModel<PaginationResult<Product>>>> GetPaginatedProducts(
            [FromQuery] int pageSize = 5,
            [FromQuery] int pageNumber = 1)
        {
            return Ok();
        }

        [HttpPut("[action]")]
        public async Task<ActionResult<ResultViewModel<Product>>> UpdateProduct([FromBody] Product model)
        {
            return Ok();
        }

        [HttpDelete("[action]")]
        public async Task<ActionResult<ResultViewModel<Product>>> DeleteProduct(int id)
        {
            return Ok();
        }
    }
}
