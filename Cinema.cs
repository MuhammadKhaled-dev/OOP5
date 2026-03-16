using System;
using System.Net.Sockets;

#region Cinema Class

class Cinema
{
    public string CinemaName;

    Projector projector = new Projector();

    Ticket[] tickets = new Ticket[20];

    public Cinema(string name)
    {
        CinemaName = name;
    }

    public void AddTicket(Ticket t)
    {
        for (int i = 0; i < tickets.Length; i++)
        {
            if (tickets[i] == null)
            {
                tickets[i] = t;
                return;
            }
        }
    }

    public void PrintAllTickets()
    {
        Console.WriteLine("--- All Tickets ---");

        foreach (Ticket t in tickets)
        {
            if (t != null)
            {
                t.Print();
            }
        }
    }

    public void OpenCinema()
    {
        Console.WriteLine("=== Cinema Opened ===");
        projector.Start();
        Console.WriteLine();
    }

    public void CloseCinema()
    {
        Console.WriteLine();
        Console.WriteLine("=== Cinema Closed ===");
        projector.Stop();
    }
}

#endregion
