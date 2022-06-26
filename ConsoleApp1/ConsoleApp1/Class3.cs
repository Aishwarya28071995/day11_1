using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //public static Node head;
    internal class StockSymbolLinkedList
    {
      public class Node
        {
           public String data;
           public  Node next;

            public Node(String data)
            {
                this.data = data;
            }
        }
        public static Node head;

        public bool Add(String data)
        {
            Node node = new Node(data);

            if (head == null)
            {
                head = node;
                return true;
            }
            node.next = head;
            head = node;
            return true;
        }

        
    }
}
