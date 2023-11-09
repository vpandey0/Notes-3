// Example Partial Class in c# ***
public partial class Employee
{
    public int Id;
    public string Name;
}
public partial class Employee
{
    public void Display(int id, string name)
    {
        Id = id;
        Name = name;
        Console.WriteLine(Id + " " + Name);
    }
}
public class MyApp
{
    public static void Main()
    {
        Employee a = new Employee();

        a.Display(1, "Vaisnavi");
    }
}

