using System;
using System.Buffers;

#region Ticket Base Class

class Ticket : IPrintable, IBookable, ICloneable
{
    static int count = 0;

    public int TicketId { get; set; }
    public string MovieName { get; set; }
    public decimal Price { get; set; }

    public bool IsBooked { get; set; }

    public Ticket()
    {
        count++;
        TicketId = count;
    }

    public decimal PriceAfterTax
    {
        get { return Price + (Price * 0.14m); }
    }

    #region Booking Methods

    public bool Book()
    {
        if (IsBooked)
        {
            Console.WriteLine("Ticket already booked.");
            return false;
        }

        IsBooked = true;
        return true;
    }

    public bool Cancel()
    {
        if (!IsBooked)
        {
            Console.WriteLine("Ticket not booked yet.");
            return false;
        }

        IsBooked = false;
        return true;
    }

    #endregion

    #region Print Method

    public virtual void Print()
    {
        Console.Write("[Ticket #" + TicketId + "] " +
        MovieName + " | Price: " + Price +
        " | After Tax: " + PriceAfterTax +
        " | Booked: " + (IsBooked ? "Yes" : "No"));
    }

    #endregion

    #region Clone Method

    public virtual object Clone()
    {
        Ticket copy = (Ticket)this.MemberwiseClone();

        count++;
        copy.TicketId = count;

        copy.IsBooked = false;

        return copy;
    }

    #endregion
}

#endregion