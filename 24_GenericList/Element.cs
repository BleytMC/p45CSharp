namespace _24_GenericList
{
    class Element<T>
    {
        public T Value { get; set; }
        public Element<T> Next { get; set; }
        public Element<T> Prev { get; set; }

        public Element(T value)
        {
            Value = value;
        }
    }
}
