public class Person
{
    protected string name;
    private string gender;
    private int age;
    public Person(string newName, string newGender,
        int newAge)
    {
        name = newName;
        gender = newGender;
        age = newAge;
    }
    public void Salute()
    {
        Console.WriteLine("Hi, my name is " + name + " and i am " + age + " years old.");
    }
}