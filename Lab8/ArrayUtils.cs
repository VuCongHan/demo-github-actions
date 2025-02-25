using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class ArrayUtils
    {
        public static int FindMax(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("Array cannot be null or empty");

            return numbers.Max();
        }

        public static int FindMin(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("Array cannot be null or empty");

            return numbers.Min();
        }
    }
}
