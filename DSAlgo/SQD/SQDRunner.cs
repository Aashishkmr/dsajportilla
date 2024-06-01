using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.SQD
{
    public class SQDRunner
    {
        public static void RunStacks()
        {
            Console.WriteLine("Creating stack");
            var stack = new Stack();

            stack.Size();
            stack.Pop();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine(stack.Peek());
            stack.Pop();
            stack.Size();
            stack.Print();
            Console.WriteLine(stack.IsEmpty());
        }

        public static void RunQueue()
        {
            var queue = new Queue();
            queue.Enqueue(1);
            queue.Print();
            queue.Enqueue(2);
            queue.Print();
            queue.Enqueue(3);
            queue.Print();
            queue.Enqueue(4);
            queue.Print();
            queue.Dequeue();
            queue.Print();
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.IsEmpty());
            Console.WriteLine(queue.Size());
            queue.Print();
        }

        public static void RunDeQueue()
        {
            var dq = new DQ();
            dq.AddFront(1);
            dq.Print();
            dq.AddFront(2);
            dq.Print();
            dq.AddRear(3);
            dq.Print();
            dq.RemoveFront();
            dq.Print();
            dq.RemoveRear();
            dq.Print();
        }
    }
}
