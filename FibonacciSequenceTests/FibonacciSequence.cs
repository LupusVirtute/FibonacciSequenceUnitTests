using System.Diagnostics.Metrics;

namespace FibonacciSequenceTests
{
    public class FibonacciSequence
    {
        public int CalculateFibonacci(int length, int a = 0, int b = 1)
        {
            if (length < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length));
            }

            if (length == 0)
            {
                return b;
            }
            return CalculateFibonacci(--length, b, a + b);
        }
    }
}