using System;

namespace PracticWork2
{
    class Program
    {
        static void Main()
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
        }

        static void Task1()
        {
            Student student = new Student();
            student.SetSurname = "Злобин";
            student.SetBirthday = new DateTime(2005, 5, 10);
            student.SetMarks = new[] { 4, 5, 5, 4, 5 };
            student.SetGroup = 612;
            student.PrintInfo();
            Console.WriteLine($"Группа текущего студента {student.GetGroup}");
            Console.WriteLine($"Оценки текущего студента {string.Join(" ", student.GetMarks)}");
            Console.WriteLine($"День рождения текущего студента {student.GetBirthday.ToString("dd-MM-yyyy")}");
            Console.WriteLine($"Фамилия текущего студента {student.GetSurname}");
        }

        static void Task2()
        {
            Train train = new Train();
            train.SetDestination = "Кемерово";
            train.SetNumber = 435;
            train.SetTime = new DateTime(2023, 6, 30, 17, 30, 0);
            train.PrintInfo();
            Console.WriteLine(train.GetNumber);
            Console.WriteLine(train.GetDestination);
            Console.WriteLine(train.GetTime);
        }

        static void Task3()
        {
            Numbers nums = new Numbers();
            nums.SetFirstNum = 120;
            nums.SetSecondNum = 230;
            Console.WriteLine($"{nums.GetFirstNum} + {nums.GetSecondNum} = {nums.Sum()}");
            Console.WriteLine($"Наибольшее число {nums.LargestNum()}");
        }

        static void Task4()
        {
            Counter counter = new Counter();
            counter.SetCounter = 5;
            while (counter.GetCounter < 10)
            {
                counter.Increment();
                Console.WriteLine(counter.GetCounter);
            }

            while (counter.GetCounter > 3)
            {
                counter.Decrement();
                Console.WriteLine(counter.GetCounter);
            }
        }

        static void Task5()
        {
            Coordinates coords = new Coordinates();
            coords.PrintCoords();
            coords = new Coordinates(10, 5);
            coords.PrintCoords();
        }
    }
}