using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.SQD
{
    public class DQ
    {
        private int size { get; set; }
        private List<int> items { get; set; }
        public DQ()
        {
            size = 0;
            items = new List<int>();
            Console.WriteLine("DeQueue");
        }

        public void AddFront(int item)
        {
            var newList = new List<int> { item };
            this.items = newList.Concat(items).ToList();
            size++;
            //
            //this.items.Insert(0,item);
        }
        public void AddRear(int item)
        {
            this.items.Add(item);
            size++;
        }

        public int RemoveRear()
        {
            var returnVal = items[size-1];
            items.RemoveAt(size- 1);
            size--;
            return returnVal;
        }

        public int RemoveFront()
        {
            var returnVal = items[0];
            items.RemoveAt(0);
            size--;
            return returnVal;
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

