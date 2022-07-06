public class OOPConcept
{
    public static void Welcome()
    {
        Console.WriteLine("Welcome to the OOPs Concept");
    }

    public static void OOPTypes()
    {
        Console.WriteLine("There are 4 basic concept of OOPs");
    }
    public void typee()
    {
        string typee = "Abstraction,Encapsulation, Inheritance, Polymorphis,";
        Console.WriteLine(typee);
    }
    public static void Main()
    {
        OOPConcept oopc = new OOPConcept();
        Welcome();
        OOPTypes();
        oopc.typee();
        Console.ReadLine();
    }
}

