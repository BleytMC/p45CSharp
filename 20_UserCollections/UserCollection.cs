using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_UserCollections
{
    class UserCollection : IEnumerator
    {
        int pos = -1;
        Element[] elementsArray;

        public UserCollection(Element[] elementsArray)
        {
            this.elementsArray = elementsArray;
        }

        public object Current
        {
            get { return elementsArray[pos]; }
        }

        public IEnumerator GetEnumerator(Element[] elementsArray)
        {
            return new UserCollectionEnumerator(elementsArray);
        }

        public bool MoveNext()
        {
            if(pos <  elementsArray.Length - 1)
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
