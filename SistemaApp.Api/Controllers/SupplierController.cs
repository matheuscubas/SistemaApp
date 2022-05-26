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
    public class SupplierController : ControllerBase
    {
        private readonly SupplierRepository _repository;
        private readonly SistemaAppDbContext _context;
        private readonly Logger _logger;

        public SupplierController(SupplierRepository repository, SistemaAppDbContext context, Serilog.ILogger logger)
        {
            _repository = repository;
            _context = context;
            _logger = logger;
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<ResultViewModel<Supplier>>> CreateSupplie([FromBody] Supplier model)
        {
            var result = new ResultViewModel<Supplier>();
            var validator = new CreateSupplierValidator();
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
                _logger.Information($"The Supplier {model.Name} was created sucessfully");
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
        [Route("[action]")]
        public async Task<ActionResult<ResultViewModel<Supplier>>> GetSupplier(int id)
        {
            return Ok();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<ResultViewModel<IEnumerable<Supplier>>>> GetSuppliers()
        {
            return Ok();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<ResultViewModel<PaginationResult<Supplier>>>> GetPagintedSuppliers()
        {
            return Ok();
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<ActionResult<ResultViewModel<Supplier>>> UpdateSupplier()
        {
            return Ok();
        }

        [HttpDelete]
        [Route("[action]")]
        public async Task<ActionResult<ResultViewModel<Supplier>>> DeleteSupplier()
        {
            return Ok();
        }
    }
}
