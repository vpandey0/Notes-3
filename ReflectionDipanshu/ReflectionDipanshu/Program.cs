using System;
using System.Reflection;

public class Browse
{
    public void Details()
    {

       Assembly ptr= Assembly.LoadFrom(@"\Day13_FinalReflection\MyAPP.dll");
       Type[] t= ptr.GetTypes();
        foreach(Type i in t)
        {
            Console.WriteLine(i);
            BrowseFunction(i);

        }
    }
    public void BrowseFunction(Type ctr)
    {
        MethodInfo[] func= ctr.GetMethods();
        foreach(var i in func)
        {
            Console.WriteLine(i.Name);
        }
    }
    public static void Main()
    {
       Browse obj=new Browse();
        obj.Details();
    }
}
