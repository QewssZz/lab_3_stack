using System;
using System.Collections.Generic;
using System.Text;

namespace lab_stack
{
    public class Stack : IStack
    {
        public Stack(int size)
        {
            items = new int[size];
        }
        private int[] items;
        private int count;
        public int Count => count;

        public void Put(int element)
        {
            if (count == items.Length)
            {
                throw new Exception("Stack is full. ");
            }
            items[count++] = element;
        }
        public int Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is empty. ");
            }
            int item = items[--count];
            items[count] = default;
            return item;
        }
        public int Item()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is empty. ");
            }
            return items[count - 1];
        }
        public bool IsEmpty()
        {
            return items.Length == 0;
        }
        public void Print()
        {
            for (int i = count - 1; i >= 0; i--)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}
