using System;

namespace ZCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,,] results = new double[21, 31, 3];
            int xIndex = 0;
            for (double x = -1; x <= 1; x += 0.1)
            {
                int yIndex = 0;
                for (double y = 1; y <= 4; y += 0.1)
                {
                    double z = 3 * (y * y) + 2 * x - 1;
                    results[xIndex, yIndex, 0] = x;
                    results[xIndex, yIndex, 1] = y;
                    results[xIndex, yIndex, 2] = z;
                    yIndex++;
                }
                xIndex++;
            }

            Console.WriteLine("x\ty\tz");
            for (int i = 0; i < 21; i++)
            {
                for (int j = 0; j < 31; j++)
                {
                    Console.WriteLine(results[i, j, 0] + "\t" + results[i, j, 1] + "\t" + results[i, j, 2]);
                }
            }
        }
    }
}
