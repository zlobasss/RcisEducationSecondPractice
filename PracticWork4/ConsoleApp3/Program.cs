using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            RimNumbers rimnum = new RimNumbers();
            rimnum.SetNum = "MCMLXXX";
            Console.WriteLine(rimnum.GetNumDec);
        }
    }
}