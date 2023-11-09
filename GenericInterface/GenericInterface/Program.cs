



class Hockey
{
    public void TotalPlayer()
    {
        Console.WriteLine("6");
    }
}
class Football
{
    public void TotalPlayerF()
    {
        Console.WriteLine("7");
    }

}
interface IPlay<T>
{
    void Play<T>(T t1);
}
class GenericPlay<T> : IPlay<T>
{
    public void Play<T1>(T1 t1)
    {
        Console.WriteLine(t1.ToString());
    }
}
class Noida
{
    public static void Main()
    {
     Football obj=new Football();
     GenericPlay<Football> objF = new GenericPlay<Football>();
     objF.Play(obj);

     Hockey obj1 = new Hockey();
     GenericPlay<Hockey> objH = new GenericPlay<Hockey>();
     objH.Play(obj1);
        obj1.TotalPlayer();



    }
}

