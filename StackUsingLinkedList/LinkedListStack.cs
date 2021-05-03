using System;
using System.Collections.Generic;
using System.Text;

namespace StackUsingLinkedList
{
    class LinkedListStack
    {
        public  Node top;
      
        /// <summary>
        /// UC1
        /// pushing the  new ndata
        /// </summary>
        /// <param name="value"></param>
        //30
        public  void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;//1300
            this.top = node;
            Console.WriteLine("{0} pushed to stack ", value);
        }
        /// <summary>
        /// Display Method
        /// </summary>
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;//1400
            }
        }
        /// <summary>
        /// Peak  from the stack till it is empty
        /// </summary>
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the stack ", this.top.data);//NullrefrenceRxception
        }
        /// <summary>
        /// Pop from the stack
        /// </summary>
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("Value popped is {0} ", this.top.data);
            this.top = this.top.next;
        }
        /// <summary>
        /// Empty method
        /// </summary>
      public void IsEmpty()
      {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
            //this.top=null;
        }

    }
}
