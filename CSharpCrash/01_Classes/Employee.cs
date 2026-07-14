namespace CSharpCrash._01_Classes;

public class Employee
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
    
    public void Introduce()
    {
        Console.WriteLine($"Hello, {Name}, you are {Age} years old!");
    }
}