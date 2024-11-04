using System;

namespace api.Entities;

public class AppUsers // in EF AppUser will be a table in the database
{
  public int Id { get; set; } // default value of int is 0

  public required string firstname { get; set; }
  public required string lastname { get; set; }

  // use pascale case for properties. in c#11 you can use required keyword to make it required
  // if nullable is not used, the default value will be null
  public required string username { get; set; }
  public required string emailId { get; set; }
  public required string gender { get; set; }
}
