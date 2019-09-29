using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using suncoast_overflow.Models;
using suncoast_overflow;
using Microsoft.EntityFrameworkCore;


namespace suncoast_overflow.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class QuestionsController : ControllerBase
  {
    private DatabaseContext context;
    public QuestionsController(DatabaseContext _context)
    {
      this.context = _context;
    }
    [HttpPost("newQuestion")]
    public ActionResult<Questions> PostQuestions([FromBody]Questions entry)
    {
      context.QuestionsTable.Add(entry);
      context.SaveChanges();
      return entry;


    }
    [HttpGet("GetAllQuestions")]
    public ActionResult<IEnumerable<Questions>> GetAll()
    {
      var AllQuestions = context.QuestionsTable.OrderBy(x => x.Id);
      return AllQuestions.ToList();
    }

    // [HttpGet("JoinAnswers{Id}")]
    // public ActionResult<IEnumerable<Object>> GetAnswers(int Id)
    // {
    //   var GetQuestions = context.QuestionsTable.Join(context.AnswersTable, x => x.Id, f => f.QuestionsID, (x, f) => new
    //   {
    //     QuestionId = x.Id,

    //   }
    //   );
    // }

  }
}