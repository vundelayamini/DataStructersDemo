using System;
using System.Collections.Generic;
using System.Text;

namespace QueueUsingLinkedList
{
    class LinkedListQueue
    {
        Node head = null;
        /// <summary>
        /// Enqueue will internally call append method on linked list
        /// </summary>
        /// <param name="data"></param>
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into queue ", node.data);

        }
        /// <summary>
        /// Display method
        /// </summary>
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

    }


}

   