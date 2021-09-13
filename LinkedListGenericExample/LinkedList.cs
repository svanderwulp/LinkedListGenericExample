using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample
{
    public class LinkedList
    {
        private Node Head;
        public int Length { get; set; }

        public LinkedList()
        {
            Head = null;
            Length = 0;
        }

        public void Insert(int value)
        {
            Head = new Node(value, Head);
            Length++;
        }

        public int? Delete()
        {
            // remove last node and return value
            Node current = Head;
            Node prev = null;
            if (current == null) return null;
            while (current.Next != null)
            {
                prev = current;
                current = current.Next;
            }
            if (prev == null) Head = null;
            else prev.Next = null;
            Length--;
            return current.Value;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            bool first = true;
            Node current = Head;
            while (current != null)
            {
                if (!first)
                {
                    sb.Append(", " + current.Value.ToString());
                }
                else
                {
                    sb.Append(current.Value.ToString());
                    first = false;
                }
                current = current.Next;
            }
            return sb.ToString();
        }
    }
}
