using System.Collections;

namespace EnumeratingInterfaces
{
    internal class DecreasingNumbers 
        : IEnumerable<int>, IEnumerator<int>
    {
        public DecreasingNumbers(int startNumber)
        {
            Current = startNumber;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /*
         *  20 -  9 -  3
         * 102 - 50 - 24 - 11 - 4 - 1
         *  50 - 24 - 11 -  4 - 1
         */
        public bool MoveNext()
        {
            Current = Current / 2 - 1;
            return Current >= 1;
        }

        public void Reset()
        {
        }

        public int Current { get; private set; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}
