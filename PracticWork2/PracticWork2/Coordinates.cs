using System;

namespace PracticWork2
{
    public class Coordinates
    {
        private int _x;
        private int _y;

        public Coordinates()
        {
            _x = 0;
            _y = 0;
        }

        public Coordinates(int x, int y)
        {
            _x = x;
            _y = y;
        }
        
        public int GetX => _x;
        public int GetY => _y;

        public void PrintCoords()
        {
            Console.WriteLine($"{_x} {_y}");
        }

        ~Coordinates()
        {
            Console.WriteLine($"Объект с координатами {_x} {_y} был удалён");
            Console.ReadKey();
        }
        
    }
}