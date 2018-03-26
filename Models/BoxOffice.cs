using System.Collections.Generic;
using theater.Assets.Enums;

namespace theater.Models
{
  public class BoxOffice
  {
    public List<Movie> Movies = new List<Movie>();

    public void SetupBoxOffice()
    {
      Director ryan = new Director() { Name = "Ryan Coogler" };
      var bp = new Movie() { Title = "Black Panther", Runtime = 90, Rating = Ratings.PG13, Director = ryan };
      var creed = new Movie() { Title = "Creed", Runtime = 90, Rating = Ratings.PG13, Director = ryan };
      Movies.Add(bp);
      Movies.Add(creed);
    }


  }
}