// // Example of Garbage Collection
// class MyApp:IDisposable
// {
//     public void Fetch()
//     {
//         Console.WriteLine("Fetching 1lac Record");
//     }
//     public static void Main()
//     {
//         using (MyApp app = new MyApp())
//         {
//             app.Fetch(); // Memory for MyApp class will be released but not during the program
//         } // At this point, Dispose func will be called
              
        
//     }

//     void IDisposable.Dispose()
//     {
//         GC.SuppressFinalize(this);
//         Console.WriteLine("Memory will be released explicitly by Dispose");
//     }
// }
// // I want to release the memory of MyApp class explicitly

class MyApp
{
    public static void Main()
    {
        int x=10;
        var y=x;
        y="Deepika";

    }
}