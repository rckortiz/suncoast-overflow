using System;

namespace suncoast_overflow.Models
{
  public class Answers
  {
    public int Id { get; set; }
    public string AnswerBody { get; set; }
    public int AnswerVotes { get; set; }
    public int? QuestionID { get; set; }
    public Questions Question { get; set; }

  }
}