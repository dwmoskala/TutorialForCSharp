using System;
using System.Collections.Generic;

namespace Lesson23
{
    class Program
    {
        static void Main()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine(queue.Peek());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Peek());

            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Peek());

            Console.ReadKey();
        }
    }
}
