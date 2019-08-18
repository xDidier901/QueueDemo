using System;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue Demo Implementation");

            Queue.PrintQueue();
            Queue.Add('a');
            Queue.PrintQueue();
            Queue.Add('e');
            Queue.PrintQueue();
            Queue.Add('i');
            Queue.PrintPeek();
            Queue.Add('o');
            Queue.PrintQueue();
            Queue.Add('u');
            Queue.PrintQueue();
            Queue.Remove();
            Queue.PrintQueue();
            Queue.Remove();
            Queue.PrintQueue();
            Queue.Remove();
            Queue.PrintQueue();
            Queue.Remove();
            Queue.PrintQueue();
            Queue.Remove();
            Queue.PrintQueue();

            Console.ReadLine();
        }
    }
}
