using System;

namespace PracticWork2
{
    public class Train
    {
        private string _destination;
        private int _number;
        private DateTime _time;

        public DateTime SetTime
        {
            set => _time = value;
        }
        public DateTime GetTime => _time;
        
        public string SetDestination
        {
            set => _destination = value;
        }
        public string GetDestination => _destination;

        public int SetNumber
        {
            set => _number = value;
        }
        public int GetNumber => _number;

        public void PrintInfo()
        {
            Console.WriteLine($"Поезд номер {_number}");
            Console.WriteLine($"Отправляется в {_time.ToString("dd.MM.yy HH:mm")}");
            Console.WriteLine($"Пункт назначения {_destination}");
        }
    }
}