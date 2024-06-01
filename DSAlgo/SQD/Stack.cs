using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.SQD
{
    public class Stack
    {
        private int size { get; set; }
        private List<int> items { get; set; }
        public Stack()
        {
            Console.WriteLine("Stacks");
            this.size = 0;
            this.items = new List<int>();
        }

        public void Push(int item)
        {
            this.items.Add(item);
            size++;
        }

        public int? Pop()
        {
            if(this.IsEmpty())
            {
                Console.WriteLine("The stack is empty");
                return null;
            }
            var returnVal = items[this.size - 1];
            this.items.RemoveAt(this.size - 1);
            size--;
            return returnVal;
        }

        public int? Peek()
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("The stack is empty");
                return null;
            }
            return items[this.size - 1];
        }

        public bool IsEmpty()
        {
            return items.Count== 0;
        }

        public int Size()
        {
            return size;
        }

        public void Print()
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("Empty stack");
            }
            foreach(var item in items)
            {
                Console.Write($"{item} | ");
            }
        }

    }
}
