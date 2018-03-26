namespace theater.Models
{

  public class Ticket
  {
    public int SeatNumber { get; set; }
    public double Price { get; set; }
    public bool Purchased { get; set; }
    public Showtime Showtime { get; set; }

  }

}