using System;
using System.Buffers;

#region Q1 : Interface in C#
/*
Interface in C# is a contract that defines method/property signatures that a class must implement.
We use interfaces instead of concrete classes to make code flexible and loosely coupled.

Benefits:
1. Loose Coupling: Code depends on interface, not class.
2. Polymorphism: Different classes can implement same interface.
3. Clear structure and easier testing.
*/
#endregion

#region Q2 : Translator Problem
/*
a) Problem: Both interfaces have Greet() method. The class currently uses a single method for both, printing "Hello / Ahlan".

b) Fix: Use Explicit Interface Implementation
Example:
class Translator : IEnglishSpeaker, IArabicSpeaker
{
    void IEnglishSpeaker.Greet() { Console.WriteLine("Hello"); }
    void IArabicSpeaker.Greet() { Console.WriteLine("Ahlan"); }
}
Technique: Explicit Interface Implementation.

c) Call: Cannot call translator.Greet() directly.
Use interface references:
((IEnglishSpeaker)t).Greet();
((IArabicSpeaker)t).Greet();
*/
#endregion

#region Q3 : Shallow vs Deep Copy
/*
Shallow Copy: copies object but reference fields point to same objects.
Deep Copy: copies object and all referenced objects independently.

Use Shallow: when reference fields can be shared.
Use Deep: when we need full independent copy.

Risk of Shallow Copy: modifying reference fields in one object affects the other.
*/
#endregion

#region Q4 : ShallowCopy Example
/*
Code:
var e1 = new Employee { Title="Dev", Dept=new Department { Name="IT" } };
var e2 = e1.ShallowCopy();
e2.Title="QA";
e2.Dept.Name="Testing";

Output:
QA - Testing
QA - Testing

Explanation:
ShallowCopy copies Employee object but Dept reference is shared.
Changing e2.Title does not affect e1.Title, but changing e2.Dept.Name affects both.
*/
#endregion

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
