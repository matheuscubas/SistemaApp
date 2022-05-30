using Microsoft.AspNetCore.Mvc;
using SistemaApp.Api.Validators;
using SistemaApp.Api.ViewModels;
using SistemaApp.Core.Dtos;
using SistemaApp.Core.Models;
using SistemaApp.Core.Repositories;
using SistemaApp.Core.Services.PasswordService;
using SistemaApp.Core.Services.TokenService;
using Logger = Serilog.ILogger;

namespace SistemaApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly IPasswordService _passwordService;
        private readonly UserRepository _repository;
        private readonly Logger _logger;

        public UserController(
            ITokenService tokenService, 
            IPasswordService passwordService,
            Logger logger,
            UserRepository repository)
        {
            _tokenService = tokenService;
            _passwordService = passwordService;
            _repository = repository;
            _logger = logger;
        }

        [HttpPost]
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

            result.Data = _tokenService.GenerateToken(user);
            result.Sucess = true;
            _logger.Information($"User {user.Username} have succesfully logged in.");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ResultViewModel<User>>> SignIn([FromBody] CrateUserDto model)
        {
            var result = new ResultViewModel<User>();
            var validator = new UserSignInViewModelValidator();
            var validationResult = await validator.ValidateAsync(model);

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
                var user = await _repository.CreateUserAsync(model);
                _logger.Information($"User {user.Username} created.");
                result.Sucess = true;
                result.Data = user;
            }
            catch(Exception ex)
            {
                _logger.Warning(ex.Message);
                result.Errors.Add(ex.Message);
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
