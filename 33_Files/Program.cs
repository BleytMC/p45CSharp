// FileStream
// StreamReader, StreamWriter
// BinaryReader, BinaryWriter
// Серіалізація об'єктів(XML, JSON)

using _33_Files;
using System.IO;
using System.Text;
using System.Xml.Serialization;

//string path = "example.txt";

//using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write)){

//    string text = "Hello World!";
//    byte[] bytes = Encoding.UTF8.GetBytes(text);

//    fileStream.Write(bytes, 0, bytes.Length);
//}


//string path = "example.txt";

//using FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

//byte[] bytes = new byte[fileStream.Length];

//fileStream.Read(bytes, 0, bytes.Length);

//string text = Encoding.UTF8.GetString(bytes);

//Console.WriteLine(text);


//string path = "data.txt";
//using StreamWriter writer = new StreamWriter(path);

//int a = 5, b = 9;
//writer.WriteLine("Hello");
//writer.WriteLine(" World");
//writer.WriteLine(1002);
//writer.Write("fefjhofiuhfoqwiufn ");
//writer.WriteLine($"a = {a} b = {b}");


//string path = "data.txt";

//using StreamReader streamReader = new StreamReader(path);
//string text = streamReader.ReadToEnd();

//string line = null;
//while((line = streamReader.ReadLine()) != null)
//{
//    Console.WriteLine(line);
//}

//Console.WriteLine(text);


//Point point = new Point { X = 4, Y = 5 };

//string path = "point.txt";
//using StreamWriter writer = new StreamWriter(path);

//writer.WriteLine(point);


//List<Point> ReadPoints(string path)
//{
//    using StreamReader reader = new StreamReader(path);
//    string line = null;
//    List<Point> points = new List<Point>();
//    while ((line = reader.ReadLine()) != null)
//    {
//        string[] parts = line.Split(",");
//        Point point = new Point();
//        point.X = Convert.ToInt32(parts[0]);
//        point.Y = Convert.ToInt32(parts[1]);
//        points.Add(point);
//    }
//    return points;
//}

//void WritePoints(string path, List<Point> points)
//{
//    using StreamWriter writer = new StreamWriter(path);
//    foreach (Point point in points) writer.WriteLine(point);
//}


//string path = "point.txt";
//List<Point> points = new List<Point>();
//points.Add(new Point { X = 8, Y = 9 });
//points.Add(new Point { X = 3, Y = 12 });
//points.Add(new Point { X = 1, Y = -95 });

//WritePoints(path, points);
//List<Point> points2 = ReadPoints(path);


//foreach(Point point in points2) Console.WriteLine(point);

//string path = "data.bin";
//using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
//{
//    using BinaryWriter binaryWriter = new BinaryWriter(fileStream);

//    binaryWriter.Write(10.2);
//    binaryWriter.Write("Hello Wolrd!");
//    binaryWriter.Write(true);
//}


//string path = "data.bin";
//using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
//{
//    using BinaryReader binaryReader = new BinaryReader(fileStream);

//    double d = binaryReader.ReadDouble();   
//    string s = binaryReader.ReadString();
//    bool b = binaryReader.ReadBoolean();

//    Console.WriteLine(d);
//    Console.WriteLine(s);
//    Console.WriteLine(b);
//}


// Серіалязація(Serialization) - це зберення стану об'єкта з метою його подальшого відновлення


// Serialization

//Point point = new Point { X = 10, Y = 20 };

//XmlSerializer xmlSerializer = new XmlSerializer(typeof(Point));

//string path = "point.xml";
//using FileStream fileStream = new FileStream(path, FileMode.Create);

//xmlSerializer.Serialize(fileStream, point);


// Deserialization


//string path = "point.xml";
//using FileStream fileStream = new FileStream(path, FileMode.Open);

//XmlSerializer xmlSerializer = new XmlSerializer(typeof(Point));

//Point point = (Point)xmlSerializer.Deserialize(fileStream);
//Console.WriteLine(point);



List<Point> points = new List<Point>();

points.Add(new Point { X = 5, Y = 8 });
points.Add(new Point { X = 6, Y = 3 });
points.Add(new Point { X = 0, Y = 12 });
points.Add(new Point { X = -2, Y = 7 });

XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Point>), new XmlRootAttribute{ElementName = "Points"});

string path = "point.xml";
using FileStream fileStream = new FileStream(path, FileMode.Create);

xmlSerializer.Serialize(fileStream, points);



//string path = "point.xml";
//using FileStream fileStream = new FileStream(path, FileMode.Open);

//XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Point>));

//List<Point> points = (List<Point>)xmlSerializer.Deserialize(fileStream);

//foreach(Point point in points) Console.WriteLine(point);