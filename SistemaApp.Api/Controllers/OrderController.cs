﻿using Microsoft.AspNetCore.Mvc;
using SistemaApp.Api.Validators;
using SistemaApp.Api.ViewModels;
using SistemaApp.Core.Data;
using SistemaApp.Core.Dtos;
using SistemaApp.Core.Models;
using SistemaApp.Core.Repositories;
using Logger = Serilog.ILogger;

namespace SistemaApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderRepository _repository;
        private readonly SistemaAppDbContext _context;
        private readonly Logger _logger;

        public OrderController(OrderRepository repository, SistemaAppDbContext context, Logger logger)
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
            var validator = new CreateOrderViewModelValidator();
            var validatorResult = await validator.ValidateAsync(model);

            if (!validatorResult.IsValid)
            {
                result.Errors.Add("An order cannot have null propertys!");
                var errors = validatorResult.Errors;
                _logger.Information(errors.First().ErrorMessage);
                foreach (var error in errors)
                    result.Errors.Add(error.ErrorMessage);
                return BadRequest(result);
            }

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
                var orderId = await _repository.CreateAsync(dto);
                var orderResult = await _repository.GetByIdAsync(orderId);

                result.Sucess = true;
                result.Data = orderResult.First();

                _logger.Information($"Your Order has been placed succesfully!");
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
        public async Task<ActionResult<ResultViewModel<IEnumerable<OrderWithNamesDto>>>> GetOrder(int id)
        {
            var result = new ResultViewModel<IEnumerable<OrderWithNamesDto>>();

            if(id < 1)
            {
                result.Errors.Add($"The Id value must be grater than 0.");
                _logger.Warning("Id value must be grater than 0.");
                return BadRequest(result);
            }

            try
            {
                var orders = await _repository.GetByIdAsync(id);
                if (!orders.Any())
                {
                    result.Data = null;
                    result.Errors.Add($"The Order with id {id} does not correspond to an active Order, please try again.");
                    return BadRequest(result);
                }
                result.Data = orders;
                result.Sucess = true;

            }
            catch(Exception ex)
            {
                if (!result.Data.Any())
                    result.Errors.Add(ex.Message);
                    result.Errors.Add($"The Order with id {id} does not correspond to an active Order, please try again.");
                    return BadRequest(result);
            }
            return Ok(result);
        }
        
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<OrderWithNamesDto>>> GetAllOrders()
        {
            var result = new ResultViewModel<IEnumerable<OrderWithNamesDto>>();

            try
            {
                var orders = await _repository.GetAllAsync();
                result.Data = orders;
                result.Sucess = true;
                _logger.Information($"returning {orders.Count()}");
            }
            catch (Exception ex)
            {
                result.Errors.Add(ex.Message);
                result.Errors.Add("Something went wrong, please try again latter.");
                return StatusCode(StatusCodes.Status500InternalServerError, result);
            }
            return Ok(result);
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<Order>>> GetPaginatedOrders(
            [FromQuery]int pageSize = 5, 
            [FromQuery]int pageNumber = 1)
        {
            if(pageSize < 1 || pageNumber < 1)
            {
                _logger.Information("The pageNumber and pageSize must be grater than 0.");
                return BadRequest("The pageNumber and pageSize must be grater than 0.");
            }

            var paginatedOrders = await _repository.GetPaginated(pageSize, pageNumber);

            return Ok(paginatedOrders);
        }

        [HttpPut("[action]")]
        public async Task<ActionResult<ResultViewModel<Order>>> UpdateOrder([FromBody]  UpdateOrderDto model)
        {
            var result = new ResultViewModel<IEnumerable<OrderWithNamesDto>>();
            var validator = new UpdateOrderDtoValidator();
            var validationResult = validator.Validate(model);

            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors;
                foreach (var error in errors)
                {
                    _logger.Information(error.ToString());
                    result.Errors.Add(error.ToString());
                }
                return BadRequest(result);
            }

            await _repository.UpdateAsync(model);
            _logger.Information($"The order {model.OrderId} has been update successfully!");
            result.Data = await _repository.GetByIdAsync(model.OrderId);
            result.Sucess = true;

            return Ok(result);
        }
        
        [HttpDelete("[action]")]
        public async Task<ActionResult> DeleteOrder(int id)
        {
            var result = new ResultViewModel<IEnumerable<OrderWithNamesDto>>();
            var order = await _repository.GetByIdAsync(id);

            if (!order.Any())
            {
                result.Errors.Add("Order not found!");
                return BadRequest(result);
            }

            result.Data = order;
            result.Sucess = true;
            await _repository.DeleteAsync(id);

            return Ok(result);
        }
    }
}
