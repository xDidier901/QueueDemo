using System;

namespace QueueDemo
{
    // First In, First Out (FIFO)
    // (head) O -> O -> O -> O -> O (tail)
    public static class Queue
    {

        // When we are removing, we are deleting the Node on the head (the first one).
        private static Node _head;

        // When we are adding, we add it to ta tail (the last one).
        private static Node _tail;

        public static bool IsEmpty()
        {
            return _head == null;
        }

        // Shows the node in the head (the next one to be out).
        public static void PrintPeek()
        {
            // If head is null, return empty char
            if (_head == null)
            {
                return;
            }

            System.Console.WriteLine($"Peek - The head is ({ _head.Value })");
        }

        // Adds a node to the queue (at the end).
        public static void Add(char value)
        {
            // We create the new node to be added.
            Node node = new Node(value);

            // If tail is not null, we add the new node as the tail
            if (_tail != null)
            {
                _tail.Next = node;
            }

            // We define the new node as the tail.
            _tail = node;

            // If head is null it means that the queue is empty
            // So head will also be the new node.
            if (_head == null)
            {
                _head = node;
            }
        }

        // Folowwing FIFO, we remove the first item that was added (the head).
        public static char Remove()
        {
            // We get the value to be extracted.
            char headValue = _head.Value;

            // We update the pointer of the head to the next node.
            _head = _head.Next;

            // If now head is null it means the queue is empty, so we update our tail too.
            if (_head == null)
            {
                _tail = null;
            }

            // Return the data of the head.
            return headValue;
        }

        // We print the state of the queue for a better understating of the process.
        public static void PrintQueue()
        {
            // If head is null the queue is empty.
            if (_head == null)
            {
                Console.WriteLine($"The queue is empty.");
                return;
            }

            var currentNode = _head;
            Console.Write($"(Head) ");
            while (currentNode != null)
            {
                Console.Write($"{currentNode.Value} => ");
                currentNode = currentNode.Next;
            }
            Console.Write($" (Tail)");
            Console.WriteLine();
        }
    }
}