﻿using System;

namespace StackUsingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();
            //linkedListStack.Peek(); top.data
            //linkedListStack.Pop();
            //linkedListStack.IsEmpty();
            //linkedListStack.Display();
            Console.ReadKey();
        }

    }
}

