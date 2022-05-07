using System;
using System.Collections;

namespace CAQueueUsingStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);

            Console.ReadLine();
        }

    }
    public class Queue
    {
        public Stack stack1 = new Stack();
        public Stack stack2 = new Stack();

        public void Enqueue(int x)
        {
            while (stack1.Count > 0)
                stack2.Push(stack1.Pop());

            stack1.Push(x);

            while (stack2.Count > 0)
                stack1.Push(stack2.Pop());
        }

        public int DeQueue()
        {
            if(stack1.Count > 0)
                Console.WriteLine("Queue is empty.");

            int x = (int)stack1.Peek();
            stack1.Pop();

            return x;
        }
    }
}
