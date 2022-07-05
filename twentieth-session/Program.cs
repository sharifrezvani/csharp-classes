using System;

namespace TwentiethSession
{
    public class LinkedListNode
    {
        public int Value { get; set; }
        public LinkedListNode Next { get; set; }

        public LinkedListNode(int x)
        {
            this.Value = x;
            this.Next = null;
        }
    }


    public class LinkedList
    {
        public LinkedListNode Head { get; set; }
        public int Count { get; set; }


        public LinkedList()
        {
            this.Head = null;
            this.Count = 0;
        }

        public void AddBeforeHead(int x)
        {
            LinkedListNode newNode = new LinkedListNode(x);

            newNode.Next = Head;

            Head = newNode;

            Count++;
        }

        public void PrintNodes()
        {
            LinkedListNode linkedListNodeObj = Head;

            while (linkedListNodeObj != null)
            {
                Console.WriteLine(linkedListNodeObj.Value);

                linkedListNodeObj = linkedListNodeObj.Next;
            }

        }



    }



    internal class Program
    {
        static void Main(string[] args)
        {

            // Linked Lists ------------------------------------------


            // LinkedList linkedList1 = new LinkedList();

            // linkedList1.AddBeforeHead(5);
            // linkedList1.AddBeforeHead(134);
            // linkedList1.AddBeforeHead(235);
            // linkedList1.AddBeforeHead(23597);
            // linkedList1.AddBeforeHead(23);

            // linkedList1.PrintNodes();


            // Stack & Queue  ------------------------------------------


            Stack<int> stack1 = new Stack<int>();

            stack1.Push(3);
            stack1.Push(24);
            stack1.Push(5);
            stack1.Push(346);
            stack1.Push(2235);

            stack1.Pop();

            
            // Console.WriteLine(stack1.Peek());  //returns the last item which was exists to the stack (the one at the top)
            
            // foreach (var item in stack1)
            // {
            //     Console.WriteLine(item);

            // }

            Queue<string> queue1 = new Queue<string>();

            queue1.Enqueue("1");
            queue1.Enqueue("2");
            queue1.Enqueue("3");
            queue1.Enqueue("4");

            // foreach (var item in queue1)
            // {
            //     Console.WriteLine(item);
                
            // }



            queue1.Dequeue();

            // foreach (var item in queue1)
            // {
            //     Console.WriteLine(item);
            // }



            // Tree  ------------------------------------------



            
        }
    }
}