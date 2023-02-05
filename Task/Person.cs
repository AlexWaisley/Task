namespace Task;

public class Person
{
    public string Name { get; }
    public int Age { get; }
    public string Password { get; }
    public string Sex { get; }
    public string Hobby { get; }
    
    public Person(string name, int age, string password, string sex, string hobby)
    {
        Name = name;
        Age = age;
        Password = password;
        Sex = sex;
        Hobby = hobby;
    }
    
}