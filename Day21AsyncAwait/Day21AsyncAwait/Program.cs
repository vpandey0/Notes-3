//// why Multi-threading
//using System.Threading;
//class MyTask
//{
//    public void Task1(Object i)  // Long running process, run this func with seperate thread
//    {
//        Thread.Sleep(4000);
//        Console.WriteLine("Performing Task-1");
//    }
//    public void Task2()  // Light weight process, use Main thread
//    {
//        Console.WriteLine("Performing Task-2");
//    }
//    public static void Main() // OS is providing 1 thread to run the application ( 1 thread = 2 function)
//    {
//        MyTask task = new MyTask();
//        Thread t = new Thread(new ParameterizedThreadStart(task.Task1)); // new thread
//        t.Start(4);
//       // task.Task1();
//        task.Task2(); // Main thread

//    }
//}
// This is Context Switching,  gives an impression it is multi-threading.
// Because all the threads are from single processor.
// Do Recommendation.. use TPL

using System;
using System.Threading.Tasks; // Example of Synchronous Programming
class MyService
{
    public void Download()
    {
        Thread.Sleep(6000);
        Console.WriteLine("Task is Completed");
    }
    public void Training()
    {
        Console.WriteLine("This is Local Task");
    }
    public void Tarun() // Will be calling LongTask()... Callback, Thread, Task
    { // Run is a Static Function of Task Class
        Task.Run(Download); // At this point new Thread will be Created on different core 
        // LongTask(); // Major Defaultor
    }
    public static void Main() // this is the Main Thread ..will be Created on different core 
    {
        MyService obj = new MyService();
        obj.Tarun();

        obj.Training(); // Training func will not be dependent on Tarun func
        Console.ReadKey();
    }

}
