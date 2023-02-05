using System.Text.Json;
using System.Text.Json.Serialization;

namespace Task;

internal class Program
{
    private static (string name, string pass) GetUserInfo()
    {
        Console.Write("Enter your name: ");
        var name = Console.ReadLine()!;
        Console.Write("Enter your password: ");
        var pass = Console.ReadLine()!;
        return (name, pass);
    }

    private static void Main()
    {
        const string path = "data.json";
        var db = new DataBase(path);
        db.Init();
        var (name, pass) = GetUserInfo();
        var user = db.GetUser(name, pass);
        if (user is null)
        {
            throw new Exception("Wrong name or password");
        }

        user.PrintInfo();
        db.Save();
    }
}