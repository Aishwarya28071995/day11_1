using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.StockAccount;

namespace ConsoleApp1
{
    internal class LinkedList
    {

        public static Node head;



        public class Node
        {
            public Node next;
            public CompanyShares data;

            public Node(CompanyShares data)
            {
                this.data = data;
            }


        }

        public void Add(CompanyShares data)
        {

            Node n = new Node(data);
            Node t = head;
            while(t!=null)
            {
                t = t.next;
            }
            t.next = n;

        }
        
    }
        
    

    }

