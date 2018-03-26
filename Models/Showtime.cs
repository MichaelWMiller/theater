namespace theater.Models
{
  public class Showtime
  {
    public Cinema Cinema { get; set; }
    public Theater Theater { get; set; }
    public Movie Movie { get; set; }
    public string Time { get; set; }
  }
}