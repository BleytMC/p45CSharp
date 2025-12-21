using System.Collections;

namespace _24_GenericList
{
    class ListEnumerator<T> : IEnumerator<T>
    {
        Element<T> head;
        Element<T> current;

        public ListEnumerator(Element<T> head)
        {
            this.head = head;
            current = null;
        }

        public T Current => current.Value;
        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            current = current == null ? head : current.Next;
            return current != null;
        }

        public void Reset()
        {
            current = null;
        }

        public void Dispose() { }
    }
}