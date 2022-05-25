﻿using Microsoft.AspNetCore.Mvc;
using SistemaApp.Api.Validators;
using SistemaApp.Api.ViewModels;
using SistemaApp.Core.Data;
using SistemaApp.Core.Dtos;
using SistemaApp.Core.Models;
using SistemaApp.Core.Repositories;
using SistemaApp.Core.Services.ConnectionService;
using SistemaApp.Core.Services.PasswordService;
using SistemaApp.Core.Services.TokenService;
using Logger = Serilog.ILogger;

namespace SistemaApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly TokenService _tokenService;
        private readonly SistemaAppDbContext _context;
        private readonly PasswordService _passwordService;
        private readonly ConnectionService _connection;
        private readonly UserRepository _repository;
        private readonly Logger _logger;

        public UserController(
            TokenService tokenService, 
            SistemaAppDbContext context, 
            PasswordService passwordService, 
            ConnectionService connection, 
            Logger logger,
            UserRepository repository)
        {
            _tokenService = tokenService;
            _context = context;
            _passwordService = passwordService;
            _connection = connection;
            _repository = repository;
            _logger = logger;
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<ResultViewModel<string>>> Login([FromBody] UserLoginViewModel model)
        {
            var result = new ResultViewModel<string>();
            var user = await _repository.GetUserAsync(model.Username);

            if(!_passwordService.IsCorrectPassword(model.Password, user))
            {
                _logger.Information("Invalid password aborting login transaction.");
                result.Errors.Add("Invalid password, please try again.");
                return BadRequest(result);
            }
            var token = _tokenService.GenerateToken(user);

            //Talvez seja necessário criar um TokenResultViewModel para poder retornar o token e + algum dado???
            //Verificar depois
            result.Data = token;
            result.Sucess = true;
            _logger.Information($"User {user.Username} have succesfully logged in.");
            return Ok(result);
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<ResultViewModel<User>>> SignIn([FromBody] CrateUserDto model)
        {
            var result = new ResultViewModel<User>();
            var validator = new UserSignInViewModelValidator();
            var validationResult = await validator.ValidateAsync(model);

            if(!validationResult.IsValid)
            {
                var errors = validationResult.Errors;
                _logger.Information(errors.First().ErrorMessage);
                foreach(var error in errors)
                result.Errors.Add(error.ToString());
                return BadRequest(result);
            }

            try
            {
                var user = await _repository.CreateUserAsync(model);
                _logger.Information($"User {user.Username} created.");
                result.Sucess = true;
                result.Data = user;
            }
            catch(Exception ex)
            {
                result.Errors.Add(ex.Message);
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}