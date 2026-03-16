using System;
using System.Buffers;

#region Booking Helper

class BookingHelper
{
    public static void PrintAll(IPrintable[] items)
    {
        Console.WriteLine();
        Console.WriteLine("--- BookingHelper.PrintAll ---");

        foreach (IPrintable item in items)
        {
            item.Print();
        }
    }
}

#endregion
