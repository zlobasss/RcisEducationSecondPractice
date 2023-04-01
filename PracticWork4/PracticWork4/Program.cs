
namespace PracticWork4
{
    class Program
    {
        static void Main()
        {
            RimNumbers rimnum = new RimNumbers();
            rimnum.SetNum = "MCMLXXX";
            Console.WriteLine(rimnum.GetNumDec);
        }
    }
}