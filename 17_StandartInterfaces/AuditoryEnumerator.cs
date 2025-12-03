using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_StandartInterfaces
{
    class AuditoryEnumerator : IEnumerator
    {
        int pos = -1;

        Student[] students;

        public AuditoryEnumerator(Student[] students)
        {
            this.students = students;
        }

        public object Current
        {
            get { return students[pos]; }
        }

        public bool MoveNext()
        {
            if(pos < students.Length - 1)
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
