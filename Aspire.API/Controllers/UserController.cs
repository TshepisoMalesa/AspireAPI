using Aspire.Security.Attributes;
using AspireAPI.Domain.DAL;
using AspireAPI.Domain.Models.RequestModels;
using AspireAPI.Domain.Models.Standard;
using AspireAPI.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Nest;
using System.Net;
using System.Text.Json;

namespace Aspire.API.Controllers
{
  [ApiKey]
  [ApiController]
  [Route("[controller]")]
  public class UserController : ControllerBase
  {

    private readonly ILogger<UserController> _logger;
    UserRepository _repoUser = new UserRepository();
    AccountRepository _repoAccount = new AccountRepository();

    public UserController(ILogger<UserController> logger)
    {
      _logger = logger;
    }
    

    [HttpGet]
    [Route("All", Name = "All")]
    public IEnumerable<User> Get()
    {
      return _repoUser.ReadAll();

    }

    [HttpGet]
    [Route("{id}", Name = "byID")]
    public User? GetById(int id)
    {
      return _repoUser.Read(id);

    }
    
    [Route("register", Name = "Registration")]
    public IActionResult PostNewAccount(string? json)
    {
      UserRegistration? account = new UserRegistration();

        account = !string.IsNullOrEmpty(json) ? JsonSerializer.Deserialize<UserRegistration>(json) : null;
        account.user = _repoUser.Create(account.user);
        account = _repoUser.Register(account);
        return Ok(account);
    }
  }
}