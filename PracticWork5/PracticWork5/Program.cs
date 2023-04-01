
namespace PracticWork5
{
    /// <summary>
    /// Класс Program 
    /// здесь описываем логику приложения
    /// вызываем нужные методы пишем обработчики и тд
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Автомобили: ");
            // DatabaseRequests.GetCar();
            // Console.WriteLine();
            // Requests.AddCar();
            Console.WriteLine("\nВодители");
            DatabaseRequests.GetDriverQuery();
            Console.WriteLine();
            Requests.AddDriver();
            Console.WriteLine("\nНазвания маршрутов:");
            DatabaseRequests.GetItinerary();
            Console.WriteLine();
            Requests.AddItinerary();
            Console.WriteLine("\nКатегории прав:");
            DatabaseRequests.GetRightsCategoryQuery();
            Console.WriteLine();
            Requests.AddRightsCategory();
            Console.WriteLine("\nМаршрут:");
            DatabaseRequests.GetRoute(1);
            Console.WriteLine();
            Requests.AddRoute();
            Console.WriteLine("\nПрава:");
            DatabaseRequests.GetDriverRightsCategoryQuery(1);
            Console.WriteLine();
            Requests.AddDriverRights();
            Console.WriteLine("Типы машин:");
            DatabaseRequests.GetTypeCarQuery();
            Console.WriteLine();
            Requests.AddTypeCar();
        }
    }
}