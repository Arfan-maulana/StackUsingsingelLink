using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingsingelLink
{
    class node
    {

        public int info;
        public node next;
        public node(int i, node n)
        {
            info = i;
            next = n;
        }
    }
        class Stack
        {
            node top;
            public Stack()
            {
                top = null;
            }
            bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);

        }
        public void push(int element)
        {

            node fresh;
            fresh = new node(element, null);
            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n" + element + "pushed");
        }


        }
















    class program
        {
        static void Main(string[] args)
        {
        }
    }
}
