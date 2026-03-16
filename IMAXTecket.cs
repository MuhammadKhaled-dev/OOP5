using System;
using System.Net.Sockets;

#region IMAX Ticket

class IMAXTicket : Ticket
{
    public bool Is3D { get; set; }

    public override void Print()
    {
        base.Print();

        string imax = "No";

        if (Is3D)
            imax = "Yes";

        Console.WriteLine(" | IMAX | 3D: " + imax);
    }
}

#endregion
