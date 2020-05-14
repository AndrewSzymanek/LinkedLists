using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    //TODO: Experiment with remove and search methods
    public class Node
    {
        //variables
        public int data;
        public Node next;

        //constructor
        public Node(int d)
        {
            data = d;
            next = null;
        }

        public void Print()
        {
            Console.Write("|" + data + "->");
            if (next != null)
            {
                next.Print();
            }
        }
        public void AddToEnd(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }
        public void AddSorted(int data)
        {
            if(next == null)
            {
                next = new Node(data);
            }
            else if(data < next.data)
            {
                Node temp = new Node(data);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                next.AddSorted(data);
            }
        }
    }

    public class MyList{

        public Node headNode;

        public MyList()
        {
            headNode = null;
        }

        public void AddToEnd(int data)
        {
            if(headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                //using recursion, method is calling itself until the condition is met
                headNode.AddToEnd(data);
            }
        }
        public void AddToBeginning(int data)
        {
            if(headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = headNode;
                headNode = temp;
            }
        }
        public void AddSorted(int data)
        {
            if(headNode == null)
            {
                headNode = new Node(data);
            }
            else if(data < headNode.data)
            {
                AddToBeginning(data);
            }
            else
            {
                headNode.AddSorted(data);
            }
        }
        public void Print()
        {
            if(headNode != null)
            {
                headNode.Print();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MyList list = new MyList();
            //list.AddToEnd(1);
            //list.AddToEnd(2);
            //list.AddToEnd(3);
            //list.AddToBeginning(4);
            //list.AddToBeginning(5);
            list.AddSorted(5);
            list.AddSorted(3);
            list.AddSorted(4);
            list.AddSorted(7);
            list.AddSorted(99);
            list.Print();
            Console.ReadLine();
        }

     
    }
}
