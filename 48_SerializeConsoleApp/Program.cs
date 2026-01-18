using _47_ClassLib;
using System.Text;
using System.Text.Json;

List<PC> pcL = new List<PC>
{
    new PC("Dell", "OptiPlex 7090", "SN001"),
    new PC("HP", "Pavilion 15", "SN002"),
    new PC("Lenovo", "ThinkPad X1", "SN003"),
    new PC("Asus", "ROG Strix", "SN004"),
    new PC("Acer", "Aspire 7", "SN005")
};

string json = JsonSerializer.Serialize(pcL, new JsonSerializerOptions { WriteIndented = true});
byte[] bytes = Encoding.UTF8.GetBytes(json);

using FileStream fileStream = new FileStream("listSerial.json", FileMode.Create, FileAccess.Write);
fileStream.Write(bytes, 0, bytes.Length);