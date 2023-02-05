using System.Text.Json;
using System.Text.Json.Serialization;

namespace Task;

public class DataBase
{
    private string Path { get; set; }
    public UsersDbModel? People { get; set; }

    public DataBase(string path)
    {
        Path = path;
    }

    public void Init()
    {
        if (File.Exists(Path))
        {
            Load();
        }
        else
        {
            People.Persons.Add(new Person("Ben", "pass", 24, "Male", "basketball"));
            People.Persons.Add(new Person("Alis", "longpass", 20, "Female", "shopping"));
        }
    }

    public void Load()
    {
        var peopleData = File.ReadAllText(Path);
        People = JsonSerializer.Deserialize<UsersDbModel>(peopleData);
    }
    public void Save()
    {
        var s = JsonSerializer.Serialize(People);
        File.WriteAllText(Path, s);
    }

    public Person GetUser(string name, string pass)
    {
        if(IsUserExists(name,pass)) return People.Persons.FirstOrDefault(person => name == person.Name && pass == person.Password);

        return null;
    }

    public bool IsUserExists(string name, string pass)
    {
        return People.Persons.Any(person => name == person.Name && pass == person.Password);
    }
}