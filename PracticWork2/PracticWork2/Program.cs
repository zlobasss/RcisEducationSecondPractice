
namespace PracticWork2;

public class Program
{
    static void Main()
    {
        //StudentTask();
        //TrainTask();
        //NumbersTask();
        //CounterTask();
        TemperatureTask();
        GC.Collect();
    }

    static void StudentTask()
    {
        List<Student> students = new List<Student>();
        string name;
        DateTime birthday = new DateTime(1999, 12, 31);

        Console.Write("Введите фамилию студента: ");
        name = Console.ReadLine()!;
        Console.Write("Введите день рождения студента в формате \"yyyy.MM.dd\": ");
        try
        {
            birthday = Convert.ToDateTime(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный формат даты!!!");
        }
        
        students.Add(new Student("Злобин", new DateTime(2005, 5, 10), 612, new[] { 5, 4, 5, 5, 4 }));
        students.Add(new Student());
        students[1].SetLastName = "Беннет";
        students[1].SetGroup = 642;
        students[1].SetMarks = new[] { 3, 3, 2, 2, 3 };
        students[1].SetDateBirthday = new DateTime(2008, 2, 29);
        for (int i = 0; i < students.Count; ++i)
        {
            students[i].GetStudentInfo(name, birthday);
        }
    }

    static void TrainTask()
    {
        List<Train> trains = new List<Train>();
        int number = 0;
        Console.Write("Введите номер поезда: ");
        try
        {
            number = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный формат числа!!!");
        }
        
        trains.Add(new Train("Колпашево", 521, new DateTime(2023, 6, 30, 17, 30, 0)));
        trains.Add(new Train("Асино", 210, new DateTime(2023, 6, 30, 14, 20, 0)));
        trains.Add(new Train("Новосибирск", 306, new DateTime(2023, 6, 29, 8, 0, 0)));

        foreach (Train train in trains)
        {
            train.GetTrainInfo(number);
        }
    }

    static void NumbersTask()
    {
        Numbers nums = new Numbers(120, 230);
        Console.WriteLine($"{nums.GetFirstNum} + {nums.GetSecondNum} = {nums.Sum()}");
        Console.WriteLine($"Наибольшее число {nums.LargestNum()}");
        
        nums.SetFirstNum = 240;
        Console.WriteLine($"{nums.GetFirstNum} + {nums.GetSecondNum} = {nums.Sum()}");
        
        nums.SetSecondNum = 290;
        Console.WriteLine($"Наибольшее число {nums.LargestNum()}");
    }

    static void CounterTask()
    {
        Counter counter = new Counter();
        counter.SetCounter = 5;
        while (counter.GetCounter < 10)
        {
            Console.WriteLine(counter.GetCounter);
            counter.Increment();
        }

        while (counter.GetCounter > 3)
        {
            Console.WriteLine(counter.GetCounter);
            counter.Decrement();
        }
    }

    static void TemperatureTask()
    {
        Temperature tomsk = new Temperature();
        tomsk.PrintInfo();
        tomsk = new Temperature(new TimeSpan(10, 0, 0), 13);
        tomsk.PrintInfo();
    }
}