using System.Text.Json;
using System.Text.Json.Serialization;

namespace Task;

internal class Program
{
    private static void Main()
    {
        const string path = "data.json";
        Console.WriteLine(File.Exists(path) ? "File exists." : "File does not exist.");
        var db = new DataBase(path);
        Console.Write("Enter your name: ");
        var name = Console.ReadLine()!;
        Console.Write("Enter your password: ");
        var pass = Console.ReadLine()!;
        if (!db.IsUserExists(name, pass))
        {
            Console.WriteLine("Wrong Name or Password.");
            return;
        }
        var User = db.GetUser(name, pass);
        User.PrintInfo();
        var s = JsonSerializer.Serialize(db.People);
        File.WriteAllText(path, s);
    }
}