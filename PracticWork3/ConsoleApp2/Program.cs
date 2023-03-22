using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1And2();
            Console.WriteLine();
            Task3();
        }

        static void Task1And2()
        {
            Worker worker = new Worker();
            worker.Name = "Константин";
            worker.Surname = "Волков";
            worker.Rate = 412.2;
            worker.Days = 30;
            Console.WriteLine($"Зарплата сотрудника {worker.Surname} {worker.Name} составляет {worker.GetSalary()}");
        }

        static void Task3()
        {
            Calculation calculator = new Calculation();
            calculator.SetCalculationLine = "Pig";
            Console.WriteLine(calculator.GetCalculationLine);
            Console.WriteLine(calculator.GetLastSymbol);
            calculator.SetLastSymbolCalculationLine = 'e';
            calculator.SetLastSymbolCalculationLine = 'r';
            Console.WriteLine(calculator.GetCalculationLine);
            Console.WriteLine(calculator.GetLastSymbol);
            calculator.DeleteLastSymbol();
            Console.WriteLine(calculator.GetCalculationLine);
            Console.WriteLine(calculator.GetLastSymbol);
        }
    }
}