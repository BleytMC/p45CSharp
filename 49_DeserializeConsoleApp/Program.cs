using _47_ClassLib;
using System.Text;
using System.Text.Json;

using FileStream fileStream = new FileStream("listSerial.json", FileMode.Open, FileAccess.Read);

byte[] bytes = new byte[fileStream.Length];
fileStream.Read(bytes, 0, bytes.Length);

string json = Encoding.UTF8.GetString(bytes);

List<PC> pcL = JsonSerializer.Deserialize<List<PC>>(json);

foreach(PC pc in pcL) Console.WriteLine(pc);