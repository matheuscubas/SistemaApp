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
            var result = new ResultViewModel<Category>();
            var validator = new CreateCategoryValidator();
            var validationResult = validator.Validate(model);

            if(!validationResult.IsValid)
            {
                _logger.Information(validationResult.Errors.First().ToString());

                foreach (var error in validationResult.Errors)
                {
                    result.Errors.Add(error.ToString());
                }

                return BadRequest(result);
            }

            try
            {
               var createdCategory = await _repository.CreateCategory(model);
                result.Data = createdCategory;
                result.Sucess = true;
                _logger.Information($"Category {createdCategory.Name} successfully created.");
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
        public async Task<ActionResult<ResultViewModel<Category>>> UpdateCategory([FromBody] Category model)
        {
            var result = new ResultViewModel<Category>();
            var validator = new UpdateCategoryValidator();
            var validationResult = validator.Validate(model);

            if(!validationResult.IsValid)
            {
                foreach(var error in validationResult.Errors)
                {
                    _logger.Information(error.ToString());
                    result.Errors.Add(error.ToString());
                }

                return BadRequest(result);
            }

            try
            {
                _repository.Update(model);
                _logger.Information($"Category {model.Name} updated successfully.");
                result.Data = await _repository.GetById(model.Id);
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

        [HttpDelete("[action]")]
        public async Task<ActionResult<ResultViewModel<Category>>> DeleteCategory(int id)
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
                result.Data = await _repository.GetById(id);
                _repository.DeleteAsync(id);
                result.Sucess = true;
                _logger.Information($"The Category {result.Data.Name} was deleted successfully.");
            }
            catch(Exception ex)
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
