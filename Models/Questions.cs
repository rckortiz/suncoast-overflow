using System;

namespace suncoast_overflow.Models
{
  public class Questions
  {
    public int Id { get; set; }
    public string QuestionTitle { get; set; }
    public string QuestionContent { get; set; }
    public int QuestionVotes { get; set; }
    public bool Answered { get; set; }
  }
}