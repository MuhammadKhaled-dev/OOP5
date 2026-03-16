using System;
using System.Net.Sockets;

#region Standard Ticket

class StandardTicket : Ticket
{
    public string SeatNumber { get; set; }

    public override void Print()
    {
        base.Print();
        Console.WriteLine(" | Standard | Seat: " + SeatNumber);
    }
}

#endregion
