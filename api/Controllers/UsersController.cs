using System;
using api.Data;
using api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("api/[controller]")] // http://localhost:5000/api/users. this is the route to access this controller
public class UsersController : ControllerBase
{

  // DataContext is a service that is injected into this controller
  // DataContext is the class that is used to interact with the database
    private readonly DataContext _context; // this value can't be changed after it's set in the constructor

  // this is constructor injection of the DataContext service
    public UsersController(DataContext context)
    {
        _context = context; // this allows _context to interact with the database
    }

    [HttpGet]
  public ActionResult<IEnumerable<AppUsers>> GetUsers()
  {
    var users = _context.Users.ToList();
    if (users == null) return NotFound();
    return Ok(users);
  }

  [HttpGet("{id}")]
  public ActionResult<AppUsers> GetUser(int id) 
  {
    var user = _context.Users.Find(id);
    if (user == null) return NotFound();
    return Ok(user);
  }
}
