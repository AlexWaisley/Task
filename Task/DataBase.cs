using System.Text.Json;
using System.Text.Json.Serialization;

namespace Task;

public class DataBase
{
    private string Path { get; set; }
    public List<Person>? People { get; set; }

    public DataBase(string path)
    {
        Path = path;
        InitListOfPeople();
    }

    private void InitListOfPeople()
    {
        if (File.Exists(Path))
        {
            var peopleData = File.ReadAllText(Path);
            People = JsonSerializer.Deserialize<List<Person>>(peopleData);
        }
        else
        {
            People = new List<Person>
            {
                new Person("Ben", "pass", 24, "Male", "basketball"),
                new Person("Alis", "longpass", 20, "Female", "shopping")
            };
        }
    }

    public void ReadFromFile()
    {
        People = JsonSerializer.Deserialize<List<Person>>(Path)!;
    }

    public Person GetUser(string name, string pass)
    {
        if(IsUserExists(name,pass))
            foreach (var person in People)
            {
                if (name == person.Name && pass == person.Password) return person;
            }

        return new Person();
    }

    public bool IsUserExists(string name, string pass)
    {
        return People.Any(person => name == person.Name && pass == person.Password);
    }
}