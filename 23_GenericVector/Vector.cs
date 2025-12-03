using _23_GenericVector;
using System.Collections;

namespace _19_VectorHomework
{
    class Vector<T> : IEnumerable
    {
        T[] mass;
        int count;

        public int Count { get { return count; } }

        public Vector()
        {
            count = 0;
            mass = new T[count];
        }

        public Vector(T[] mass)
        {
            count = mass.Length;
            this.mass = mass;
        }

        public override string ToString()
        {
            return string.Join(", ", mass);
        }

        public void PushBack(T value)
        {
            T[] arr = new T[count + 1];
            for (int i = 0; i < count; i++) arr[i] = mass[i];
            arr[count] = value;
            mass = arr;
            count++;
        }

        public T PopBack()
        {
            T[] arr = new T[count - 1];
            for (int i = 0; i < count - 1; i++) arr[i] = mass[i];
            T res = mass[count - 1];
            mass = arr;
            count--;
            return res;
        }

        public void Insert(int index, T value)
        {
            if (index > count || index < 0) throw new IndexOutOfRangeException();
            T[] arr = new T[count + 1];
            for (int i = 0; i < count + 1; i++)
            {
                if (i < index) arr[i] = mass[i];
                else if (i > index) arr[i] = mass[i - 1];
                else arr[i] = value;
            }
            mass = arr;
            count++;
        }

        public void Erase(int index)
        {
            if (index >= count || index < 0) throw new IndexOutOfRangeException();
            T[] arr = new T[count - 1];
            for (int i = 0; i < count - 1; i++)
            {
                if (i < index) arr[i] = mass[i];
                else arr[i] = mass[i + 1];
            }
            mass = arr;
            count--;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public T At(int index)
        {
            if (index >= count || index < 0) throw new IndexOutOfRangeException();
            return mass[index];
        }

        public void Reverse()
        {
            T[] arr = new T[count];
            for (int i = 0; i < count; i++) arr[i] = mass[count - i - 1];
            mass = arr;
        }

        public void Clear()
        {
            mass = new T[0];
            count = 0;
        }

        public IEnumerator GetEnumerator()
        {
            return new VectorEnumerator<T>(mass);
        }

        public T this[int index]
        {
            get { return mass[index]; }
        }
    }
}