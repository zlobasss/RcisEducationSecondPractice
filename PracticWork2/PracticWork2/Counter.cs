namespace PracticWork2
{
    public class Counter
    {
        private int _counter;

        public Counter()
        {
            _counter = 0;
        }

        public int SetCounter
        {
            set => _counter = value;
        }
        
        public int GetCounter => _counter;

        public void Increment()
        {
            ++_counter;
        }

        public void Decrement()
        {
            --_counter;
        }
    }
}