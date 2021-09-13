using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListGenericExample
{
    public class LinkedListGeneric<T>
    {
        private Node<T> Head;
        public int Length { get; set; }

        public LinkedListGeneric()
        {
            Head = null;
            Length = 0;
        }

        public void Insert(T value)
        {
            Head = new Node<T>(value, Head);
            Length++;
        }

        public T Delete()
        {
            // sadly, generic type T is not necessarily nullable
            // just return the default value for type
            T def = default;  // default value for type T
            Node<T> current = Head;
            Node<T> prev = null;
            if (current == null) return def;
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
            Node<T> current = Head;
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
