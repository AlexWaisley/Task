namespace Task;

public class Person
{
    public string Name { get; }
    public int Age { get; }
    public string Password { get; }
    public string PSex { get; }
    public string Hobby { get; }
    
    public Person(string name = "Null", string password = "None", int age = 0, string pSex = "", string hobby = "")
    {
        Name = name;
        Age = age;
        Password = password;
        PSex = pSex;
        Hobby = hobby;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Sex: {PSex}");
        Console.WriteLine($"Hobby: {Hobby}");
    }
}