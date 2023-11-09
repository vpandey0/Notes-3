class Candidate 
{
    private int Expr;
    private string Skills;
    private string Qual;

    public int Experience
    {
        get
        {
            return Expr;
        }
        set
        {
            Expr= value;
            if(Expr<3)
            {
                Console.WriteLine("Criteria Failed");
            }
        }
    }
    public string SkillSets
    {
        get
        {
            return Skills;  
        }
        set
        {
            Skills= value;
        }  
    }
    public string Qualification
    {
        get
        {
            return Qual;
        }
        set
        {
            Qual = value;
        }
    }

}
class HR
{

}

class Organisation
{
    public static void Main()
    {
     Candidate deepak= new Candidate();
        deepak.Experience = 2;  // Set
        deepak.SkillSets = "C#";
        deepak.Qualification = "B.Tech";
        Console.WriteLine(deepak.Experience); // Get
        Console.WriteLine("My Skill set is: " + deepak.SkillSets);
        Console.WriteLine("My Qualification: " + deepak.Qualification);
    
    }

}
