using System;

namespace suncoast_overflow.Models
{
  public class UserInfo
  {
    public int Id { get; set; }
    public int Upvotes { get; set; }
    public int Downvotes { get; set; }
    public string Comment { get; set; }
    public string Questions { get; set; }
  }
}