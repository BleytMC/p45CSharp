using System.Collections;

namespace _18_ICoparerTask
{
    class AccountLastNameComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if(x is Account && y is Account) return (x as Account).LastName.CompareTo((y as Account).LastName);
            throw new NotImplementedException();
        }
    }
}
