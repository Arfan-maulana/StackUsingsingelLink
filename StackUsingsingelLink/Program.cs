using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

        public void pop()
        {
            Console.WriteLine("\nThe poped element is :" + top.info);
            top = top.next; // make top point to the next node is squence
        }

        public void display()
        {
            node tmp;
            if (empty())
                Console.WriteLine("\nStack Empty");
            else
            {
                for (tmp = top; tmp!= null; tmp = tmp.next)
                {
                    Console.WriteLine(top.info);
                }
            }
        }
    }

    class program
        {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            while(true)
            {
                Console.WriteLine();
                Console.WriteLine("***Stack Menu***\n");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. pop ");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. exit");
                Console.WriteLine("\nEnter your choice");
                string input = Console.ReadLine();1`
                char ch = Convert.ToChar(input == "" ? "0" : input);
                switch(ch)
                {
                    case '1':
                        Console.WriteLine("\nEnter a number : ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        s.push(num);
                        break;
                    case '2':
                        if(s.empty())
                        {
                            Console.WriteLine("\nStack empty");
                            break;
                        }
                        s.pop();
                        break;
                }
            }
        }
    }
}
