using System;
using System.Collections.Generic;
using System.Text;

namespace queue
{
    public class MyQueue
    {
        public Node front;
        public Node rear;
        public int Count { get; private set; }

         public void Enqueue(int x )
        {
            
            var t = new Node(x);
            ++Count;

            if (rear ==null)
            {
                front = rear = t;

            }

            rear.next = t;
            rear = t;

            
        }

        public void Dequeue()
        {
            if (front == null)
            {
                return;
            }

            var t = front;
            front = front.next;

            if (front == null)
            {
                rear = null;

            }
            --Count;
        }
    }
}
