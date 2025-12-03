using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Generics
{
    class MyClass<T>
    {
        T a;

        public MyClass()
        {
            a = default(T);
        }

        public MyClass(T a)
        {
            this.a = a;
        }

        public T A
        {
            get { return a; }
            set { a = value; }
        }

        public override string ToString()
        {
            return $"a: {a}";
        }
    }
}
