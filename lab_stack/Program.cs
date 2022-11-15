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
                Stopwatch timer1 = new Stopwatch();
                Stopwatch timer2 = new Stopwatch();
                Stopwatch timer3 = new Stopwatch();
                Stopwatch timer4 = new Stopwatch();
                Stopwatch timer5 = new Stopwatch();
                Stopwatch timer6 = new Stopwatch();

                Stack stack = new Stack(4);
                timer1.Start();
                stack.Put(1);
                stack.Put(31);
                stack.Put(27);
                stack.Put(12);
                timer1.Stop();

                Console.WriteLine("Stack: {0}", timer1.Elapsed);
                stack.Print();
                Console.WriteLine();

                timer3.Start();
                int pop = stack.Pop();
                timer3.Stop();

                Console.WriteLine("Time of pop: " + timer3.Elapsed + " ELement of pop: " + pop);
                stack.Print();
                Console.WriteLine();


                timer4.Start();
                int item = stack.Item();
                timer4.Stop();

                Console.WriteLine("Time of item: " + timer4.Elapsed + " ELement of item: " + item);
                stack.Print();
                Console.WriteLine();



                StackList stacklist = new StackList();
                timer2.Start();
                stacklist.Put(11);
                stacklist.Put(22);
                stacklist.Put(35);
                stacklist.Put(44);
                timer2.Stop();

                Console.WriteLine("Stacklist: {0}", timer2.Elapsed);
                stacklist.Print();
                Console.WriteLine();

                timer5.Start();
                int poplist = stacklist.Pop();
                timer5.Stop();

                Console.WriteLine("Time of poplist: " + timer5.Elapsed + " ELement of poplist: " + poplist);
                stacklist.Print();
                Console.WriteLine();


                timer6.Start();
                int itemlist = stacklist.Item();
                timer6.Stop();

                Console.WriteLine("Time of itemlist: " + timer6.Elapsed + " ELement of itemlist: " + itemlist);
                stacklist.Print();
                Console.WriteLine();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

    
   
}
