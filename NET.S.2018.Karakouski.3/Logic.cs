using System;

namespace NET.S._2018.Karakouski._3
{

    /// <summary>
    ///Implents  FindNthRoot method
    /// </summary>
    public static class Logic
    {
        /// <summary>
        /// Claulates nth root of a number using Newton's method
        /// </summary>
        /// <param name="number"></param>
        /// <param name="root"></param>
        /// <param name="tolerance"></param>
        /// <returns></returns>
        public static double FindNthRoot(double number, int root, double tolerance=0.001)
        {

            if (tolerance < 0)
                throw new ArgumentException(nameof(tolerance));

            if (root < 0)
                throw new ArgumentException(nameof(root));

            double estimation = number;
            for (int i=0; true && Math.Abs(Math.Pow(estimation, root) - number) > tolerance; i++) ///1000000000 limit for possible infinite or close to infinite loops
                estimation = (number / Math.Pow(estimation, root - 1) + (estimation*(root-1))) / (root);

            return estimation;
        }
    }
}
