using System;

namespace SecondHighest
{
    public class SecondHighest
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Format("Second highest in [5, 2, -1, 8, 10, -7] is {0}", SecondHighestInArray(new int[] {5,2,-1,8,10,-7})));
        }

        /// <summary>
        /// Returns the second highest element in the array
        /// </summary>
        /// <returns>The second highest in array.</returns>
        /// <param name="array">Supplied array of numbers.</param>
        public static int SecondHighestInArray(int[] array)
        {
            var highest = Int32.MinValue;
            var secondHighest = Int32.MinValue;

            foreach (int i in array)
            {
                if (i > highest)
                {
                    secondHighest = highest;
                    highest = i;
                }
                else if (i > secondHighest)
                {
                    secondHighest = i;
                }
            }
            return secondHighest;

        }

    }
}
