using System;

#region Booking Interface

interface IBookable
{
    bool Book();
    bool Cancel();
}

#endregion