using System.Xml.Serialization;

namespace _33_Files
{
    public class Point
    {
        [XmlAttribute("X")]
        public int X { get; set; }

        [XmlAttribute("Y")]
        public int Y { get; set; }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public override string ToString()
        {
            return $"{X},{Y}";
        }
    }
}
