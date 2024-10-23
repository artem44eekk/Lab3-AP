using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            Console.WriteLine("Enter an integer n (n >= 1): ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
            {
                Console.WriteLine("Invalid input. Please enter an integer n (n >= 1): ");
            }

            Console.WriteLine("Enter a real number x (x != 0): ");
            double x;
            while (!double.TryParse(Console.ReadLine(), out x) || x == 0)
            {
                Console.WriteLine("Invalid input. Please enter a real number x (x != 0): ");
            }

            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int exponent = 2 * i - 1;
                double term = Math.Pow(-1, i - 1) * exponent / Math.Pow(x, i);
                sum += term;
            }

            Console.WriteLine("The sum of the series is: " + sum);

            // task 2
            double X = 1.25;
            int k = 8;
            double epsilon = 1e-6;
            double totalSum = 0.0;
            int iteration = 1;
            double currentTerm = 1.0;

            while (true)
            {
                double iterationValue = iteration;
                double numerator = Math.Exp(Math.Log(iterationValue) * Math.Log(iterationValue));
                double denominator = Math.Pow(X + Math.Log(iterationValue), (int)iterationValue);
                currentTerm = numerator / denominator;

                if (Math.Abs(currentTerm) < epsilon)
                {
                    break;
                }

                totalSum += currentTerm;

                Console.WriteLine($"Iteration: {iteration}");
                Console.WriteLine($"Current term: {currentTerm}");
                Console.WriteLine($"Accumulated sum: {totalSum}");
                Console.WriteLine($"Achieved error: {Math.Abs(currentTerm / totalSum)}\n");

                iteration++;
            }

            Console.WriteLine($"Final sum of the series: {totalSum}");

            // task 3
            double a = 3.5;
            double b = 10.5;
            double h = 0.2;

            Console.WriteLine("x\t\tf(x)\t\tg(x)");
            for (double xValue = a; xValue <= b; xValue += h)
            {
                double f = Math.Cos(1.5 * xValue) * Math.Log10(2.5 * xValue);
                double g = Math.Exp(1 / Math.Sqrt(xValue)) * Math.Sin(xValue);

                Console.WriteLine($"{xValue:F2}\t\t{f:F6}\t\t{g:F6}");
            }

        }
    }
}
