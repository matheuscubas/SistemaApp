using Microsoft.AspNetCore.Mvc;
using SistemaApp.Api.ViewModels;
using SistemaApp.Core.Data;
using SistemaApp.Core.Models;
using SistemaApp.Core.Repositories;
using Logger = Serilog.ILogger;

namespace SistemaApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly SistemaAppDbContext _context;
        private readonly Logger _logger;
        private readonly CategoryRepository _repository;

        public CategoryController(SistemaAppDbContext context, Serilog.ILogger logger, CategoryRepository repository)
        {
            _context = context;
            _logger = logger;
            _repository = repository;
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<ResultViewModel<Category>>> CreateCategory([FromBody] Category model)
        {
            return Ok(model);
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<ResultViewModel<Category>>> GetCategory(int id)
        {
            var result = new ResultViewModel<Category>();

            if (id < 1)
            {
                result.Errors.Add($"The Id value must be grater than 0.");
                _logger.Warning("Id value must be grater than 0.");
                return BadRequest(result);
            }

            try
            {
                var category = await _repository.GetById(id);

                result.Data = category;
                result.Sucess = true;
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
        public async Task<ActionResult<ResultViewModel<Category>>> GetAllCategories()
        {
            var result = new ResultViewModel<IEnumerable<Category>>();

            try
            {
                var categories = await _repository.GetAllAsync();
                result.Data = categories;
                result.Sucess = true;
                _logger.Information($"returning {categories.Count()}");
            }
            catch(Exception ex)
            {
                result.Errors.Add(ex.Message);
                _logger.Warning(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, result);
            }
            
            return Ok(result);
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<ResultViewModel<PaginationResult<Category>>>> GetPaginatedCategories(
            [FromQuery] int pageSize = 5,
            [FromQuery] int pageNumber = 1)
        {
            var result = new ResultViewModel<PaginationResult<Category>>();

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
            catch(Exception ex)
            {
                result.Errors.Add(ex.Message);
                _logger.Information(ex.Message);
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpPut("[action]")]
        public async Task<ActionResult<ResultViewModel<Category>>> UpdateCategory()
        {
            return Ok();
        }

        [HttpDelete("[action]")]
        public async Task<ActionResult<ResultViewModel<Category>>> DeleteCategory()
        {
            return Ok();
        }
    }
}
