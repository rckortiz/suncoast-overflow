using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using suncoast_overflow.Models;

namespace suncoast_overflow.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnswersController : ControllerBase
  {
    private DatabaseContext context;
    public AnswersController(DatabaseContext _context)
    {
      this.context = _context;
    }
    [HttpPost("NewAnswer")]
    public ActionResult<Answers> NewAnswer([FromBody] Answers entry)
    {
      context.AnswersTable.Add(entry);
      context.SaveChanges();
      return entry;
    }
    [HttpGet("AllAnswers")]
    public ActionResult<IEnumerable<Answers>> GetAllAnswers()
    {
      var all = context.AnswersTable.OrderBy(x => x.Id);
      return all.ToList();
    }
  }
}