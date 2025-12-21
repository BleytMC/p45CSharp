using System.Collections;

namespace _24_GenericList
{
    class List<T> : IEnumerable<T>
    {
        Element<T> head;
        Element<T> tail;

        public void AddTail(T value)
        {
            if(head == null)
            {
                head = new Element<T>(value);
                tail = head;                
            }
            else
            {
                tail.Next = new Element<T>(value);
                tail.Next.Prev = tail;
                tail = tail.Next;
            }
        }

        public void AddHead(T value)
        {
            if(head == null)
            {
                head = new Element<T>(value);
                tail = head;
            }
            else
            {
                head.Prev = new Element<T>(value);
                head.Prev.Next = head;
                head = head.Prev;
            }
        }

        public void RemoveTail()
        {
            if (tail == null)
                throw new IndexOutOfRangeException();

            if (head == tail)
            {
                head = tail = null;
            }
            else
            {
                tail = tail.Prev;
                tail.Next = null;
            }
        }

        public void RemoveHead()
        {
            if (head == null)
                throw new IndexOutOfRangeException();

            if (head == tail)
            {
                head = tail = null;
            }
            else
            {
                head = head.Next;
                head.Prev = null;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ListEnumerator<T>(head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
