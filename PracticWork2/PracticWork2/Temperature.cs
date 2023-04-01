namespace PracticWork2;

public class Temperature
{
    private TimeSpan _time;
    private int _temper;

    public Temperature()
    {
        _time = new TimeSpan(0, 0, 0);
        _temper = -1;
    }

    public Temperature(TimeSpan time, int temper)
    {
        _temper = temper;
        _time = time;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Время: {_time} \nТемпература = {_temper}");
    }

    ~Temperature()
    {
        Console.WriteLine($"Объект с температурой {_temper} был успешно удален");
    }
}