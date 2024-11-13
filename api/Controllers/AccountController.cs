using System;
using System.Security.Cryptography;
using System.Text;
using api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
public class AccountController : BaseApiController
{
  [HttpPost("register")] // the path here is /account/register
  public async Task<ActionResult<AppUsers>> Register(string username, string password)
  {
    using var hmac = new HMACSHA512(); // this is used to hash the password

    var user = new AppUsers
    {
      username = username,
      PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)), // this is will have unique hash for each password
      PasswordSalt = hmac.Key // this is the key that will be used to hash the password
    };
  }

}
