
namespace PracticWork2;

public class Train
{
    private string _name;
    private int _number;
    private DateTime _time;

    public Train(string name, int number, DateTime time)
    {
        _name = name;
        _number = number;
        _time = time;
    }

    public void GetTrainInfo(int number)
    {
        if (number == _number)
        {
            string result = "Поезд №" + _number;
            result += "\nОтправляется в " + _name;
            result += "\nВремя отправления: " + _time.ToString("dd.MM HH:mm");
             
            Console.WriteLine(result);
        }
    }
}