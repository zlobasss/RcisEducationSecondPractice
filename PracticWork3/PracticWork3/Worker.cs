
namespace PracticWork3
{
    public class Worker
    {
        private string _name;
        private string _surname;
        private double _rate;
        private int _days;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Surname
        {
            get => _surname;
            set => _surname = value;
        }
        public double Rate
        {
            get => _rate;
            set => _rate = value;
        }

        public int Days
        {
            get => _days;
            set => _days = value;
        }

        public double GetSalary()
        {
            return _rate * _days;
        }
    }
}