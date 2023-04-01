
namespace PracticWork4
{
    public class RimNumbers
    {
        private readonly Dictionary<char, int> _rimNumbers = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        private string _num;

        public RimNumbers()
        {
            _num = "";
        }

        public string GetNum => _num;

        public string SetNum
        {
            set => _num = value;
        }

        public int GetNumDec
        {
            get
            {
                int last = _rimNumbers[_num[0]];

                int decNum = last;

                for (int i = 1; i < _num.Length; ++i)
                {
                    int temp = _rimNumbers[_num[i]];
                    if (last < temp && (last.ToString()[0] == '1' && last * 10 >= temp))
                    {
                        decNum = decNum - last + last * (-1) + temp;
                    }
                    else if (last >= temp)
                    {
                        decNum += temp;
                    }
                    
                    last = temp;
                }
                
                return decNum;
            }
        }
    }
}