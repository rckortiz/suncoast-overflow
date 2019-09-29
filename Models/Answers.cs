using System;
using System.Collections.Generic;

namespace suncoast_overflow.Models
{
  public class Answers
  {
    public int Id { get; set; }
    public string AnswerBody { get; set; }
    public int AnswerVotes { get; set; }
    public int? QuestionsID { get; set; }
    public Questions Questions { get; set; }

  }
}