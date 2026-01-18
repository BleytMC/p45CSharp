using _46_FilesHM;
using System.Text;
using System.Text.Json;

Shop shop = new Shop("Arsen", [
    new Product("Bread", 25.0, "Fresh bread"),
    new Product("Milk", 32.5, "1L milk"),
    new Product("Cheese", 120.0, "Hard cheese"),
    new Product("Apple", 15.0, "Red apple"),
    new Product("Chocolate", 45.0, "Dark chocolate")
]);

string json = JsonSerializer.Serialize(shop, new JsonSerializerOptions { WriteIndented = true});
byte[] bytes = Encoding.UTF8.GetBytes(json);

using FileStream streamWriter = new FileStream("shop.json", FileMode.Create, FileAccess.Write);
streamWriter.Write(bytes, 0, bytes.Length);

streamWriter.Close();

using FileStream streamReader = new FileStream("shop.json", FileMode.Open, FileAccess.Read);
byte[] finalBytes = new byte[streamReader.Length];

streamReader.Read(finalBytes, 0, finalBytes.Length);

string finalText = Encoding.UTF8.GetString(finalBytes);

Console.WriteLine(finalText);