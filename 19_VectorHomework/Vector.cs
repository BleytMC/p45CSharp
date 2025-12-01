using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_VectorHomework
{
    class Vector
    {
        int[] mass;
        int count;

        public int Count { get { return count; } }

        public Vector()
        {
            count = 0;
            mass = new int[count];
        }

        public Vector(int[] mass)
        {
            count = mass.Length;
            this.mass = mass;
        }

        public override string ToString()
        {
            return string.Join(", ", mass);
        }

        public void PushBack(int value)
        {
            int[] arr = new int[count + 1];
            for (int i = 0; i < count; i++) arr[i] = mass[i];
            arr[count] = value;
            mass = arr;
            count++;
        }

        public int PopBack()
        {
            int [] arr = new int[count - 1];
            for (int i = 0; i < count - 1; i++) arr[i] = mass[i];
            int res = mass[count - 1];
            mass = arr;
            count--;
            return res;
        }

        public void Insert(int index, int value)
        {
            if(index > count || index < 0) throw new IndexOutOfRangeException();
            int[] arr = new int[count + 1];
            for(int i = 0; i < count + 1; i++)
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
            if(index >= count || index < 0) throw new IndexOutOfRangeException();
            int[] arr = new int[count - 1];
            for(int i = 0; i < count - 1; i++)
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

        public int At(int index)
        {
            if (index >= count || index < 0) throw new IndexOutOfRangeException();
            return mass[index];
        }

        public void Reverse()
        {
            int[] arr = new int[count];
            for (int i = 0; i < count; i++) arr[i] = mass[count - i - 1];
            mass = arr;
        }

        public void Clear()
        {
            mass = new int[0];
            count = 0;
        }

        public int this[int index]
        {
            get { return mass[index]; }
        }
    }
}
