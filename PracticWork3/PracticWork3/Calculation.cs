
namespace PracticWork3
{
    public class Calculation
    {
        private string _calculationLine;

        public string SetCalculationLine
        {
            set
            {
                this._calculationLine = value;
            }
        }

        public char SetLastSymbolCalculationLine
        {
            set
            {
                this._calculationLine += value;
            }
        }

        public string GetCalculationLine => _calculationLine;

        public char GetLastSymbol => _calculationLine[_calculationLine.Length - 1];

        public void DeleteLastSymbol()
        {
            _calculationLine = _calculationLine.Remove(_calculationLine.Length - 1);
        }
    }
}