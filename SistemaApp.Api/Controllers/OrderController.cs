using Microsoft.AspNetCore.Mvc;
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

        public OrderController(OrderRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<Order>> CreateOrder(
            [FromBody] Order model)
        {
            //adicionar validações do model

            _repository.Create(model); 
            return Ok();
        }


        [HttpGet("[action]")]
        public async Task<ActionResult<Order>> GetOrder(
            [FromBody] int id)
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

        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<Order>>> GetPaginatedOrders(
            [FromBody] int pageSize, 
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
