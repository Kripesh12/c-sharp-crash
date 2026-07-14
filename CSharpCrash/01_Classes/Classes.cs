namespace CSharpCrash._01_Classes;

public static class Classes
{
    public static void Run()
    {
        Employee employee = new Employee();
        employee.Name = "James";
        employee.Age = 20;
        
        employee.Introduce();
    }
}