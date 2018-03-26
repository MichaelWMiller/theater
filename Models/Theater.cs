using System.Collections.Generic;

namespace theater.Models
{
  public class Theater
  {
    public string Name { get; set; }
    public int RoomNumber { get; set; }
    public int Capacity { get; set; }
    public List<Ticket> Tickets { get; set; } = new List<Ticket>();


  }
}