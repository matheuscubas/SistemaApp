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
    public class ShipperController : ControllerBase
    {
        private readonly ShipperRepository _repository;
        private readonly SistemaAppDbContext _context;
        private readonly Logger _logger;

        public ShipperController(ShipperRepository repository, SistemaAppDbContext context, Serilog.ILogger logger)
        {
            _repository = repository;
            _context = context;
            _logger = logger;
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<ResultViewModel<Shipper>>> CreateShipper([FromBody] Shipper model)
        {
            var result = new ResultViewModel<Shipper>();
            var validator = new CreateShipperValidator();
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
                _logger.Information($"The Shipper {model.Name} was created sucessfully");
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
        public async Task<ActionResult<ResultViewModel<Shipper>>> GetShipper(int id)
        {
            return Ok();
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<ResultViewModel<IEnumerable<Shipper>>>> GetAllShippers()
        {
            return Ok();
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<ResultViewModel<PaginationResult<Shipper>>>> GetPaginatedShippers(
            [FromQuery] int pageSize = 5,
            [FromQuery] int pageNumber = 1)
        {
            return Ok();
        }

        [HttpPut("[action]")]
        public async Task<ActionResult<ResultViewModel<Shipper>>> UpdateShipper()
        {
            return Ok();
        }

        [HttpDelete("[action]")]
        public async Task<ActionResult<ResultViewModel<Shipper>>> DeleteShipper()
        {
            return Ok();
        }
    }
}
