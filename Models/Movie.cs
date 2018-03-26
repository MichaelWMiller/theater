using theater.Assets.Enums;

namespace theater.Models
{
  public class Movie
  {
    public string Title { get; set; }
    public Ratings Rating { get; set; }
    public long Runtime { get; set; }

    public Director Director { get; set; }
  }

}