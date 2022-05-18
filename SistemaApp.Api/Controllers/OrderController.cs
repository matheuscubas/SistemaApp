using Microsoft.AspNetCore.Mvc;
using SistemaApp.Api.ViewModels;
using SistemaApp.Core.Data;
using SistemaApp.Core.Dtos;
using SistemaApp.Core.Models;
using SistemaApp.Core.Repositories;

namespace SistemaApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderRepository _repository;
        private readonly SistemaAppDbContext _context;
        private readonly ILogger<OrderController> _logger;

        public OrderController(OrderRepository repository, SistemaAppDbContext context, ILogger<OrderController> logger)
        {
            _repository = repository;
            _context = context;
            _logger = logger;
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<ResultViewModel<OrderWithNamesDto>>> CreateOrder(
            [FromBody] CreateOrderViewModel model)
        {
            var result = new ResultViewModel<OrderWithNamesDto>();
            //adicionar validações do model
            var dto = new CreateOrderDto()
            {
                CustomerId = model.CustomerId,
                EmployeeId = model.EmployeeId,
                ShipperId = model.ShipperId,
                ProductId = model.ProductId,
                Quantity = model.Quantity
            };

            try
            {
                var orderId = _repository.Create(dto, _context);
                var orderResult = _repository.GetById(orderId).First();

                result.Sucess = true;
                result.Data = orderResult;

                _logger.LogInformation($"{orderId}");
                _logger.LogInformation($"Your Order has been placed succesfully!");
            }
            catch(Exception ex)
            {
                result.Errors.Add(ex.Message);
                return BadRequest(result);
            }
            return Ok(result);
        }


        [HttpGet("[action]")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var order = _repository.GetById(id);

            return Ok(order);
        }
        
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<OrderWithNamesDto>>> GetAllOrders()
        {
            var orders = _repository.GetAll();

            return Ok(orders);
        }


        //Não ta funfando tentar arrumar depois
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<Order>>> GetPaginatedOrders(
            int pageSize, 
            int pageNumber)
        {
            var paginatedOrders = _repository.GetPaginated(pageSize, pageNumber);

            return Ok(paginatedOrders);
        }

        [HttpPut("[action]")]
        public async Task<ActionResult<Order>> UpdateOrder([FromBody] Order model)
        {
            //Adicionar validações pra checar se o model é valido

            _repository.Update(model);

            return Ok();
        }
        
        [HttpDelete("[action]")]
        public async Task<ActionResult> DeleteOrder([FromBody] int id)
        {
            _repository.Delete(id);

            return Ok();
        }
    }
}
