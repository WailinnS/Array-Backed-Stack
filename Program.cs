using System;

namespace Array_Backed_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
                var value = stack.Peek();
                Console.WriteLine(value);
            }            
            Console.WriteLine("Values added to stack");
            for (int i = 0; i < 5; i++)
            {
                var value = stack.Peek();
                Console.WriteLine(value);
                stack.Pop();
            }

        }
    }
}
