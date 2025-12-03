using System.Collections;

namespace _24_GenericList
{
    class ListEnumerator<T> : IEnumerator
    {
        Element<T> head;
        Element<T> current;

        public ListEnumerator(Element<T> head)
        {
            this.head = head;
            current = null;
        }

        public object Current
        {
            get { return current; }
        }

        public bool MoveNext()
        {
            if (current == null && head != null)
            {
                current = head;
                return true;
            }
            else if (current?.Next != null)
            {
                current = current.Next;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            current = null;
        }
    }
}
