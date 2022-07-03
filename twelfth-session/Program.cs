using System;
using System.Collections.Generic;
using System.IO;

namespace TwelfthSession
{

    // public class Event : IEquatable<Event>, IComparable<Event>
    // {

    //     public int Time { get; set; }
    //     public string EventType { get; set; }
    //     public int ID { get; set; }



    //     public Event(int id, int time, string eventType)
    //     {
    //         this.Time = time;
    //         this.EventType = eventType;
    //         this.ID = id;
    //     }

    //     public bool Equals(Event? other)
    //     {
    //         bool result = false;
    //         if (EventType == other.EventType && Time == other.Time)
    //         {
    //             result = true;
    //         }
    //         return result;
    //     }

    //     public int CompareTo(Event? other)
    //     {


    //         if (EventType.CompareTo(other.EventType) == 1)
    //         {
    //             return 1;
    //         }
    //         else if (EventType.CompareTo(other.EventType) == -1)
    //         {
    //             return -1;
    //         }
    //         else
    //         {
    //             return 0;
    //         }
    //     }

    //     public void Print()
    //     {
    //         Console.WriteLine(ID + ", " + Time + ", " + EventType);
    //     }
    // }

    internal class Program
    {

        static void Main(string[] args)
        {

            // First Exercise ------------------------------------



            // Ticket firstEventObj = new Ticket(1234, 20,"Concert");
            // Ticket secondEventObj = new Ticket(1234, 20,"Movie");

            // Console.WriteLine(firstEventObj.Equals(secondEventObj));


            // Second Exercise -------------------------------------

            // List<Event> eventList = new List<Event>();


            // eventList.Add(new Event(12233, 21, "Movie"));
            // eventList.Add(new Event(12743, 18, "Concert"));
            // eventList.Add(new Event(13467, 22, "Exhibition"));
            // eventList.Add(new Event(11852, 13, "Gallery"));
            // eventList.Add(new Event(13205, 12, "Theater"));

            // ticketList.Sort();

            // foreach (var item in ticketList)
            // {
            //     item.Print();
            // }


            // Third Exercise --------------------------------------


            // List<string> eventNameList = new List<string>(eventList.Count);


            // eventNameList.Add("Dog Day Afternoon");
            // eventNameList.Add("NOEL");
            // eventNameList.Add("Banksy");
            // eventNameList.Add("Dastan Gallery");
            // eventNameList.Add("Phantom of the Opera");



            // Dictionary<string, Event> events =  new Dictionary<string, Event>();


            // for (var i = 0; i < eventList.Count; i++)
            // {
            //     events.Add(eventNameList[i], eventList[i]);
            // }

            // foreach (var item in events)
            // {
            //     Console.WriteLine($"{item.Key} -> ID: {item.Value.ID}, Time: {item.Value.Time} P.M., Type: {item.Value.EventType}\n");
            // }



            // Fourth Exercise ---------------------------------


            Console.WriteLine(Factorial(7));
            Console.WriteLine(RecursiveAddition(5));
            



            // Fifth Exercise -----------------------------------


            // string readFile = File.ReadAllText(@"C:/Users/98903/Desktop/classes/twelfth-session/twelfth-session.txt");

            // Console.WriteLine(readFile);;


            // File.WriteAllText("C:/Users/98903/Desktop/classes/twelfth-session/newFile.txt", "Text was added!");
            // Console.WriteLine(File.ReadAllText("C:/Users/98903/Desktop/classes/twelfth-session/newFile.txt"));


        }




        public static double Factorial(int number)
        {
            if (number == 0)
                return 1;
            return number * Factorial(number - 1);//Recursive call    
        }

        public static double RecursiveAddition(int number)
        {
            if (number == 1)
                return 1;
            return number + RecursiveAddition(number - 1);//Recursive call    
        }

    }
}