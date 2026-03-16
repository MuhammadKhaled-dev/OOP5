using System;
using System.Net.Sockets;

#region VIP Ticket

class VIPTicket : Ticket
{
    public bool LoungeAccess { get; set; }
    public decimal ServiceFee { get; set; }

    public override void Print()
    {
        base.Print();

        string access = "No";

        if (LoungeAccess)
            access = "Yes";

        Console.WriteLine(" | VIP | Lounge: " + access +
        " | Fee: " + ServiceFee);
    }
}

#endregion