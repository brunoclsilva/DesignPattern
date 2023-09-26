namespace DesignPatterns.Behavioral.Iterator
{
    public class MonthIterator : IMonthIterator
    {
        private int _index;
        private int _count = 0;
        private readonly string[] _months;
        private readonly int _fiscalMonthStart;

        public MonthIterator(string[] months, int fiscalMonthStart)
        {
            if (months.Length != 12)
            {
                throw new ArgumentException("The number of months is not 12");
            }

            if (fiscalMonthStart < 0 || fiscalMonthStart > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(fiscalMonthStart));
            }

            _months = months;
            _fiscalMonthStart = fiscalMonthStart;

            _index = _fiscalMonthStart - 2;
        }

        public string Current
        {
            get
            {
                if (_index < 0 || _index > _months.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                _count++;
                return _months[_index];
            }
        }

        public bool MoveNext()
        {
            if (_count >= 12)
            {
                return false;
            }

            _index++;
            if (_index == _months.Length)
            {
                _index = 0;
            }

            return true;
        }

        public void Reset()
        {
            _count = 0;
            _index = _fiscalMonthStart - 2;
        }
    }
}
