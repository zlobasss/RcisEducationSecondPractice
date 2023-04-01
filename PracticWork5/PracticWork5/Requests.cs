namespace PracticWork5;

public class Requests
{
    public static void AddTypeCar()
    {
        Console.Write("Введите новый тип транспорта: ");
        var carQuery = Console.ReadLine()!;
        DatabaseRequests.AddTypeCarQuery(carQuery);
    }

    public static void AddDriver()
    {
        Console.WriteLine("Добавляем нового водителя...");
        Console.Write("Имя водителя: ");
        var firstName = Console.ReadLine();

        Console.Write("Фамилия водителя: ");
        var lastName = Console.ReadLine();

        Console.Write("День рождения водителя: ");
        DateTime birth = new DateTime();
        try
        {
            birth = Convert.ToDateTime(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный формат даты!!!");
        }
        DatabaseRequests.AddDriverQuery(firstName, lastName, birth);
    }

    public static void AddRightsCategory()
    {
        Console.Write("Название новой категории: ");
        string rights = Console.ReadLine();
        DatabaseRequests.AddRightsCategoryQuery(rights);
    }

    public static void AddDriverRights()
    {
        Console.WriteLine("Добавляем права водителю...");
        Console.Write("Номер водителя: ");
        int driverNum;
        try
        {
            driverNum = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            driverNum = 1;
            Console.WriteLine("Вы ввели не число!!!");
        }
        Console.WriteLine("Категории прав: ");
        DatabaseRequests.GetRightsCategoryQuery();
        Console.Write("Введите номер категории: ");
        int rightsNum;
        try
        {
            rightsNum = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            rightsNum = 1;
            Console.WriteLine("Вы ввели не число!!!");
        }
        DatabaseRequests.AddDriverRightsCategoryQuery(driverNum, rightsNum);
    }

    public static void AddCar()
    {
        Console.WriteLine("Добавляем новый автомобиль...");
        Console.Write("Введите название автомобиля: ");
        string nameCar = Console.ReadLine();

        Console.Write("Введите номер автомобиля: ");
        string numbCar = Console.ReadLine();

        Console.Write("Введите кол-во мест в автомобиле: ");
        int numbPessenger;
        try
        {
            numbPessenger = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            numbPessenger = 1;
            Console.WriteLine("Вы ввели не число!!!");
        }

        Console.Write("Введите номер типа автомобиля: ");
        int idTypeCar;
        try
        {
            idTypeCar = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            idTypeCar = 1;
            Console.WriteLine("Вы ввели не число!!!");
        }

        DatabaseRequests.AddCar(nameCar, numbCar, numbPessenger, idTypeCar);
    }

    public static void AddItinerary()
    {
        Console.Write("Введите название Маршрута: ");
        string nameItinerary = Console.ReadLine();
        DatabaseRequests.AddItinerary(nameItinerary);
    }

    public static void AddRoute()
    {
        Console.WriteLine("Добавляем новый маршрут...");
        Console.Write("Введите id водителя: ");
        int idDriver;
        try
        {
            idDriver = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            idDriver = 1;
            Console.WriteLine("Вы ввели не число!!!");
        }
        Console.Write("Введите id машины: ");
        int idCar;
        try
        {
            idCar = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            idCar = 1;
            Console.WriteLine("Вы ввели не число!!!");
        }
        Console.Write("Введите id маршрута: ");
        int idItinerary;
        try
        {
            idItinerary = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            idItinerary = 1;
            Console.WriteLine("Вы ввели не число!!!");
        }
        Console.Write("Введите кол-во пассажиров: ");
        int passengerCount;
        try
        {
            passengerCount = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            passengerCount = 1;
            Console.WriteLine("Вы ввели не число!!!");
        }
            
        DatabaseRequests.AddRoute(idDriver, idCar, idItinerary, passengerCount);
    }
}