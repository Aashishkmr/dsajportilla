using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.SQD
{
    public class Queue
    {
        private int size { get; set; }
        private List<int> items { get; set; }
        public Queue()
        {
            this.size = 0;
            this.items = new List<int>();
            Console.WriteLine("Queue");
        }

        public void Enqueue(int item)
        {
            this.items.Add(item);
            size++;
        }

        public int? Dequeue()
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("The queue is empty");
                return null;
            }
            var returnVal = items[0];
            this.items.RemoveAt(0);
            size--;
            return returnVal;
        }

        public int? Peek()
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("The q is empty");
                return null;
            }
            return items[0];
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }

        public int Size()
        {
            return size;
        }

        public void Print()
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("Empty Q");
            }
            Console.Write("Front");
            foreach (var item in items)
            {
                Console.Write($"{item} | ");
            }
            Console.WriteLine("Back");
        }
    }
}
