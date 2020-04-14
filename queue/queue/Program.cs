using System;

namespace queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = new MyQueue();

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Dequeue();

            Console.WriteLine(q.front.key);
        }
    }
}
