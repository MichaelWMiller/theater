using System;
using System.Collections.Generic;

namespace theater.Models
{
  public class Cinema
  {
    public string Name { get; set; }
    public Address Address { get; set; }
    public double DefaultTicketPrice { get; set; }
    public List<Theater> Theaters { get; set; } = new List<Theater>();
    public List<Showtime> Showtimes { get; set; } = new List<Showtime>();


    public void CreateTheaterDetails()
    {
      System.Console.WriteLine("Theater Name: ");
      var name = Console.ReadLine();
      int rn = -1;
      while (rn < 0)
      {
        System.Console.WriteLine("Theater Number: ");
        var roomNumber = Console.ReadLine();
        int.TryParse(roomNumber, out rn);
        Console.Clear();
      }
      int rc = -1;
      while (rc < 0)
      {
        System.Console.WriteLine("Theater Capacity: ");
        var capacity = Console.ReadLine();
        int.TryParse(capacity, out rc);
        Console.Clear();
      }
      CreateTheater(name, rn, rc);
    }

    public void CreateTheater(string name, int roomNumber, int capacity)
    {
      Theaters.Add(new Theater()
      {
        Name = name,
        RoomNumber = roomNumber,
        Capacity = capacity
      });
    }


    public void PrintShowtimes()
    {
      Showtimes.ForEach(showtime =>
        {
          System.Console.WriteLine($@"
        -----------------------------------------------------
        | {showtime.Movie.Title} | {showtime.Time} |
        ------------------------------------------------------
            ");
        });
    }

    public void ShowAvailableTickets(Showtime showtime)
    {
      System.Console.WriteLine($@"
-----------------------------------------------------
| Price | Seat |
------------------------------------------------------");
      showtime.Theater.Tickets.ForEach(ticket =>
      {
        if (!ticket.Purchased)
        {
          System.Console.WriteLine($@"
${ticket.Price} | {ticket.SeatNumber}");
        }
      });
    }

    public void CreateShowtime(Theater theater, Movie movie, string time)
    {
      var newShowtime = new Showtime()
      {
        Cinema = this,
        Theater = theater,
        Movie = movie,
        Time = time
      };
      Showtimes.Add(newShowtime);
      MakeTickets(newShowtime);
    }

    private void MakeTickets(Showtime showtime)
    {
      for (var i = 0; i < showtime.Theater.Capacity; i++)
      {
        showtime.Theater.Tickets.Add(new Ticket()
        {
          Showtime = showtime,
          Price = DefaultTicketPrice,
          SeatNumber = i + 1
        });
      }
    }



  }
}