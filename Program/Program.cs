using System;
using AverageCalculator_nspc;

namespace workspace
{

    public class Program
    {
        public static void Main()
        {
            var number = new AverageCalculator();
            double[] b = {1, 2};
            number.Add(b);
            double[] back = number.GetElements();

            Console.WriteLine(back[0]);
            Console.WriteLine(back[1]);
            Console.WriteLine(number.getAverage());
        }
    }
}
