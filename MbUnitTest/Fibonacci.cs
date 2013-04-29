namespace MbUnitTest
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public class Fibonacci
    {
        /// <summary>
        /// Calculates the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <returns></returns>
        public static int Calculate(int x)
        {
            if (x <= 0)
                return 0;

            if (x == 1)
                return 1;

            return Calculate(x - 1) + Calculate(x - 2);
        }
    }
}
