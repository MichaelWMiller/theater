using System;
using theater.Assets.Enums;
using theater.Models;

namespace theater
{
  class Program
  {
    static void Main(string[] args)
    {
      if (RunTests())
      {
        Application app = new Application();
        User jake = new User("Jake", "MarkIsAwesome");
        User mark = new User("Mark", "IKnow");
        User bryce = new User("Bryce", "IHeartBetos");

        //Add Users to Dictionary
        app.UsersTable.Add("jake", jake);
        app.UsersTable.Add("mark", mark);
        app.UsersTable.Add("bryce", bryce);

        app.Start();
      }

    }

    static bool RunTests()
    {
      try
      {
        //creating cinema
        BoxOffice bx = new BoxOffice();
        bx.SetupBoxOffice();
        Cinema village = new Cinema()
        {
          Name = "The Village",
          Address = new Address() { StreetAddress = "123 fake str." },
          DefaultTicketPrice = 11.99
        };
        village.CreateTheater("Theater 7", 7, 3);
        village.CreateShowtime(village.Theaters[0], bx.Movies.Find(m => m.Title == "Black Panther"), "12:00 PM");
        village.PrintShowtimes();
        village.ShowAvailableTickets(village.Showtimes[0]);
      }

      catch (Exception error)
      {
        System.Console.WriteLine(error.Message);
        return false;
      }
      return true;
    }
  }
}
