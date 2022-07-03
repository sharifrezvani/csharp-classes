using System;

namespace SixteenthSession
{


    public class Eve
    {
        
        public void FunForEvent(object sender , EventArgs e){
            System.Console.WriteLine("called by event ........");
        }
        public event EventHandler SpaceEvent;
        public void GetKey (){
       var name =     Console.ReadKey();
       if (name.Key == ConsoleKey.Backspace)
       {
       // System.Console.WriteLine("backspace called");
      
             SpaceEvent?.Invoke(this,EventArgs.Empty);
        
       
       }



        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

     Eve objEve = new Eve();
     objEve.SpaceEvent +=objEve.FunForEvent;
     objEve.GetKey();
            // First Exercise (Action<> and Func<>) ---------------------------------------------------



            // Action<int, int> actionObject = (int a, int b ) => Console.WriteLine($"{a} + {b} = {a + b}");
            // actionObject += (int a, int b ) => Console.WriteLine($"{a}  {b} = {a - b}");
            // actionObject += (int a, int b ) => Console.WriteLine($"{a} * {b} = {a * b}");

            // actionObject(5,7);


            // Func<string, string> funcObject = Greet;
            // funcObject += WishWell;
            // funcObject += Farewell;

            // Console.WriteLine(funcObject("Ron"));
            

            // Second Exercise (Action<> and Func<>) ---------------------------------------------------
            
  


        }

        // public static string Greet(string name)
        // {
        //     return $"Hello, {name}";
        // }

        // public static string WishWell(string name)
        // {
        //     return $"I hope you are having a nice day, {name}!";
        // }
        
        // public static string Farewell(string name)
        // {
        //     return $"See you next time, {name}!";
        // }
        


    }
}