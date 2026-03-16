using System;
using System.Buffers;

#region Main Program

class Program
{
    static void Main(string[] args)
    {
        Cinema c = new Cinema("VOX");

        c.OpenCinema();

        StandardTicket t1 = new StandardTicket();
        t1.MovieName = "Inception";
        t1.Price = 80;
        t1.SeatNumber = "A5";

        VIPTicket t2 = new VIPTicket();
        t2.MovieName = "Avengers";
        t2.Price = 200;
        t2.LoungeAccess = true;
        t2.ServiceFee = 50;

        IMAXTicket t3 = new IMAXTicket();
        t3.MovieName = "Dune";
        t3.Price = 130;
        t3.Is3D = true;

        // Booking
        t1.Book();
        t2.Book();
        t3.Book();

        c.AddTicket(t1);
        c.AddTicket(t2);
        c.AddTicket(t3);

        c.PrintAllTickets();

        #region Clone Test

        Console.WriteLine();
        Console.WriteLine("--- Clone Test ---");

        VIPTicket clone = (VIPTicket)t2.Clone();
        clone.MovieName = "Interstellar";

        Console.Write("Original : ");
        t2.Print();

        Console.Write("Clone    : ");
        clone.Print();

        #endregion

        #region Cancel Ticket

        Console.WriteLine();
        Console.WriteLine("--- After Cancellation ---");

        t1.Cancel();
        t1.Print();

        #endregion

        #region Helper Print

        BookingHelper.PrintAll(new IPrintable[] { t1, t2, t3 });

        #endregion

        c.CloseCinema();
    }
}

#endregion