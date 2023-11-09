class MyApp
{
    public void Connect()
    {

        string[] i = new string[3];
        try
        {
            int a = 0;
            i[a++] = "Vaishnavi";
            i[a++] = "Vaishnavi Pandey";
            i[a++] = "Vaishnavi Garg";
           
            //if (a<i.Length)
           // {
                i[3] = "Vishal";
                Console.WriteLine(i[3]);
           // }
           // else
            //{
              //  Console.WriteLine("Dont exceed the limit");
            //}
            
        }
       
       
        catch (IndexOutOfRangeException b)
        {
            Console.WriteLine("Abc" + b.Message);
        }

        catch (Exception e)
        {
            Console.WriteLine("Abc1"+ e.Message);
        }
        


    }
    public static void Main()
    {
        MyApp obj = new MyApp();
        obj.Connect();
    }
}