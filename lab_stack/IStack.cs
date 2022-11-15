using System;
using System.Collections.Generic;
using System.Text;

namespace lab_stack
{
    public interface IStack
    {
        public void Put(int element);
        public int Pop();
        public int Item();
        public bool IsEmpty();
        public void Print();
    }
}
