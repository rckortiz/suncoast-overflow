using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using suncoast_overflow;
using suncoast_overflow.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace suncoast_overflow.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UserInfoController : ControllerBase
  {
    private DatabaseContext context;
    public UserInfoController(DatabaseContext _context)
    {
      this.context = _context;
    }
  }
}