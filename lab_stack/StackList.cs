using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_stack
{
    public class StackList : IStack
    {
        
        private List<int> items = new List<int>();      
        public int Count => items.Count;
        public void Put(int item)
        {
            if (item == null)
            {
                throw new Exception("Item is null");
            }


            items.Add(item);
        }

        
        public int Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is empty.");
            }
            var item = items.LastOrDefault();

            items.RemoveAt(items.Count - 1);

            return item;
        }

        
        public int Item()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is empty.");
            }
            var item = items.LastOrDefault();
       
            return item;
        }
        public bool IsEmpty()
        {
            return items.Count == 0;
        }

        public void Print()
        {
            for (int i = items.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}
