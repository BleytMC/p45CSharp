using System.Collections;

namespace _18_ICoparerTask
{
    class AccountCreationTimeComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if(x is Account && y is Account) return (x as Account).CreationTime.CompareTo((y as Account).CreationTime);
            throw new NotImplementedException();
        }
    }
}
