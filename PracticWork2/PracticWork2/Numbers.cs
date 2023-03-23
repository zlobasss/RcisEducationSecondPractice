namespace PracticWork2
{
    public class Numbers
    {
        private int _firstNum;
        private int _secondNum;

        public int SetFirstNum
        {
            set => _firstNum = value;
        }
        public int GetFirstNum => _firstNum;

        public int SetSecondNum
        {
            set => _secondNum = value;
        }
        public int GetSecondNum => _secondNum;

        public int Sum()
        {
            return _firstNum + _secondNum;
        }

        public int LargestNum()
        {
            return _firstNum > _secondNum ? _firstNum : _secondNum;
        }
    }
}