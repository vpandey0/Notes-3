
public delegate void NotifyMe(string message);
class Car
{
    public int distance { get; set; }
    public event NotifyMe Open;

    public void Callme(string msg)
    {

    }
   
}
class Owner
{
    public static void Main()
    {
        Car obj=new Car();
        
        
    }
}