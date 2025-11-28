using System.Collections;

namespace _17_StandartInterfaces
{
    class StudentCardComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is Student && y is Student) return (y as Student).StudentCard.CompareTo((x as Student).StudentCard);
            throw new NotImplementedException();
        }
    }
}
