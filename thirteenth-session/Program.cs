using System;
using System.IO;

namespace ThirteenthSession
{
    class Program
    {

        static void Main(string[] args)
        {

            // First Exercise ------------------------------------------- (FileStream and such)

            // FileStream fs1 = new FileStream(@"C:\Users\98903\Desktop\classes\thirteenth-session\new-file.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

            // StreamWriter streamWriterObj = new StreamWriter(fs1);

            // streamWriterObj.WriteLine("Pellentesque sed posuere leo. Maecenas ipsum est, mattis nec sapien et, blandit tempus justo. Pellentesque ut est tristique, placerat lacus vitae, maximus lacus. Sed pretium blandit turpis, vel facilisis magna lacinia ut. Cras porttitor tristique lectus, in tincidunt erat tincidunt id. Aenean pellentesque felis a orci sodales, non eleifend neque viverra. Nulla imperdiet aliquet dolor, quis elementum ex. Duis id efficitur tellus.");

            // streamWriterObj.AutoFlush = true;

            // Console.WriteLine("done!");

            // fs1.Close();

            // FileStream fs2 = new FileStream(@"C:\Users\98903\Desktop\classes\thirteenth-session\new-file.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);

            // StreamReader streamReaderObj = new StreamReader(fs2);

            // string text = streamReaderObj.ReadToEnd();

            // Console.WriteLine(text);


            // Second Exercise ----------------------------------------------------- (Lambda Expression (Linq))


            // -----------------------------------------------------------------------------

            // List<string> studentList = new List<string>(){"Dave", "John", "Bob", "Dave"};

            // List<string> newStudentList = new List<string>(){"Ronald", "John", "Dave", "Ross", "Tim"};

            // List<int> scoreList = new List<int>(){1, 2, 3, 4, 5};

            // studentList.AddRange(newStudentList);

            // studentList.ForEach(i=>Console.WriteLine(i));

            // studentList.Distinct();

            // studentList.ForEach(i=>Console.WriteLine(i));


            // studentList.All(i => i.StartsWith("D"));
            // Console.WriteLine(studentList.All(i => i.StartsWith("D")));


            // studentList.Any(i => i.StartsWith("D"));
            // Console.WriteLine(studentList.Any(i => i.StartsWith("D")));

            // -----------------------------------------------------------------------------

            // Level 1 ----------

            // Console.WriteLine("Enter a text:");
            // string text = Console.ReadLine();


            // List<string> textItems = text.Split(",").ToList();

            // textItems.Chunk(3).ElementAt(0).ToList().ForEach(i => Console.WriteLine(i));

            // Level 2 ----------

            Console.WriteLine("Enter a text:");
            string? text = Console.ReadLine();

            String.Equals(text.Substring(0, text.Length / 2), text.Substring(text.Length / 2, text.Length).Reverse());


        }
    }
}