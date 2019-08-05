using System;

namespace ProgrammingProblems
{
    public interface IFibonacci
    {
        long GetFibonacciNumberAtIndex(int n);
    }

    public class FibonacciUsingIterativeSolution : IFibonacci
    {
        public long GetFibonacciNumberAtIndex(int n)
        {
            long fibonacciNumber = 0;

            switch (n)
            {
                case 1:
                    fibonacciNumber = 0;
                    break;
                case 2:
                case 3:
                    fibonacciNumber = 1;
                    break;
                default:
                    if (n <= 0)
                    {
                        throw new InvalidOperationException("n should be greater than zero.");
                    }
                    else
                    {
                        long twoStepBackFibonacci = 1, oneStepBackFibonacci = 1;
                        for (int i = 4; i <= n; i++)
                        {
                            fibonacciNumber = twoStepBackFibonacci + oneStepBackFibonacci;
                            twoStepBackFibonacci = oneStepBackFibonacci;
                            oneStepBackFibonacci = fibonacciNumber;
                        }
                    }

                    break;
            }

            return fibonacciNumber;
        }
    }

    public class FibonacciUsingRecursiveSolution : IFibonacci
    {
        public long GetFibonacciNumberAtIndex(int n)
        {
            long fibonacciNumber = 0;

            switch (n)
            {
                case 1:
                    fibonacciNumber = 0;
                    break;
                case 2:
                case 3:
                    fibonacciNumber = 1;
                    break;
                default:
                    if (n <= 0)
                        throw new InvalidOperationException("n should be greater than zero.");
                    else
                        fibonacciNumber = GetFibonacciNumberAtIndex(n - 2) + GetFibonacciNumberAtIndex(n - 1);

                    break;
            }

            return fibonacciNumber;
        }
    }
}