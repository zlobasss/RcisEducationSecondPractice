using System;
using System.Linq;

namespace ConsoleApp3
{
    public class RimNumbers
    {
        private static readonly int[] numbers = new int[7] { 1, 5, 10, 50, 100, 500, 1000 };
        private static readonly char[] rimNumbers = new char[7] { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };

        private string _num;

        private bool correctWriteNum()
        {
            int repet = 1;
            int indexLast = 0;
            for (int i = 1; i < _num.Length; ++i)
            {
                if (_num[indexLast] == _num[i])
                {
                    ++repet;
                    if (repet >= 4)
                    {
                        return false;
                    }
                }
                if (Array.IndexOf(rimNumbers, _num[indexLast]) < Array.IndexOf(rimNumbers, _num[i]) && (repet > 1 || (indexLast % 2 == 0 && indexLast < i - 2)))
                {
                    return false;
                }
                if (_num[indexLast] != _num[i])
                {
                    repet = 1;
                }
            }

            return true;
        }

        public string GetNum => _num;

        public string SetNum
        {
            set { _num = value; }
        }

        public int GetNumDec
        {
            get
            {
                if (!correctWriteNum() || _num.Length <= 0)
                {
                    Console.WriteLine("Число отсутствует или введено неверно!!!");
                    return 0;
                }
                int last = 0;
                int indexLast = 0;
                int index = 0;
                indexLast = Array.IndexOf(rimNumbers, _num[0]);
                last = numbers[indexLast];

                int decNum = last;

                for (int i = 1; i < _num.Length; ++i)
                {
                    index = Array.IndexOf(rimNumbers, _num[i]);
                    int temp = numbers[index];
                    if (last < temp && (indexLast % 2 == 0 && indexLast >= index - 2))
                    {
                        decNum = decNum - last + last * (-1) + temp;
                    }
                    else if (last >= temp)
                    {
                        decNum += temp;
                    }

                    indexLast = index;
                    last = temp;
                }
                
                return decNum;
            }
        }
    }
}