using System.Globalization;

namespace ConsoleApp2
{
    public class Worker
    {
        private string _name;
        private string _surname;
        private double _rate;
        private int _days;

        public string Name
        {
            get { return _name;}
            set { this._name = value; }
        }

        public string Surname
        {
            get { return _surname;}
            set { this._surname = value; }
        }
        public double Rate
        {
            get { return _rate; }
            set { this._rate = value; }
        }

        public int Days
        {
            get { return _days; }
            set { this._days = value; }
        }

        public double GetSalary()
        {
            return _rate * _days;
        }
    }
}