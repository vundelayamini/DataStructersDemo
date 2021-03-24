using System;

namespace DataStructresDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            //list.InsertAtParticularPosition(2,30);
            list.Display();
            Console.ReadKey();
        }
    }
}
