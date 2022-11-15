using System;
using System.Diagnostics;

namespace lab_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Stopwatch timer1 = new Stopwatch();
                //Stack stack = new Stack(100000000);
                //for (int i = 0; i < 100000000; i++)
                //{
                //    stack.Put(i);
                //}
                //timer1.Start();
                //for (int i = 0; i < 100000000; i++)
                //{
                //    stack.Pop();
                //}
                //timer1.Stop();
                //Console.WriteLine(timer1.Elapsed);


                Stopwatch timer2 = new Stopwatch();
                StackList stacklist = new StackList();
                for (int i = 0; i < 100000000; i++)
                {
                    stacklist.Put(i);
                }
                timer2.Start();
                for (int i = 0; i < 100000000; i++)
                {
                    stacklist.Pop();
                }
                timer2.Stop();
                Console.WriteLine(timer2.Elapsed);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

    
   
}
