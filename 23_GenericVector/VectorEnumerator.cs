using System.Collections;

namespace _23_GenericVector
{
    class VectorEnumerator<T> : IEnumerator
    {
        int pos = -1;

        T[] mass;

        public VectorEnumerator(T[] mass)
        {
            this.mass = mass;
        }

        public object Current
        {
            get { return mass[pos]; }
        }

        public bool MoveNext()
        {
            if(pos < mass.Length - 1)
            {
                pos++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            pos = -1;
        }
    }
}
