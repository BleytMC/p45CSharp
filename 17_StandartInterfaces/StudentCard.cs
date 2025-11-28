namespace _17_StandartInterfaces
{
    class StudentCard: IComparable, ICloneable
    {
        public int Number { get; set; }
        public string Series { get; set; }

        public object Clone()
        {
            //return new StudentCard()
            //{
            //    Number = this.Number,
            //    Series = this.Series
            //};
            return this.MemberwiseClone();
        }

        public int CompareTo(object? obj)
        {
            if(obj is  StudentCard)
            {
                StudentCard other = obj as StudentCard;
                return Number.CompareTo(other.Number);
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Student card: {Series} {Number} ";
        }
    }
}
