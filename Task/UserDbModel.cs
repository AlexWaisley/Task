namespace Task;

[Serializable]
public class UsersDbModel
{
    public List<Person> Persons { get; set; } = new();
}