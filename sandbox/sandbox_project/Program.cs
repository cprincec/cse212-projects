using System;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        // Console.WriteLine("Hello Sandbox World!");
        Run();

        void Run()
        {
            // var executionTime = Time(() => LotsOfLoops(3), 10);
            // Console.WriteLine($"Execution Time: {executionTime} ms");
            Factorial(5);
        }

        int Factorial(int n)
        {
            if (n <= 1)
            {
                // 1! = 1 (no recursion)
                Console.WriteLine("n is 1", 1);
                return 1;
            }
            else
            {
                // n! = n * (n - 1)!
                var res = n * Factorial(n - 1);
                Console.WriteLine(res);
                return res;
            }
        }

        //     void LotsOfLoops(int n)
        //     {
        //         int total = 0;
        //         for (int i = 0; i < n; i++)
        //         {
        //             for (int j = 0; j < n; j++)
        //             {
        //                 for (int k = 0; k < n; k++)
        //                 {
        //                     total += (i * j * k);
        //                 }
        //             }
        //         }

        //         Console.WriteLine($"{total},");
        //     }

        //     double Time(Action executeAlgorithm, int times)
        //     {
        //         var sw = System.Diagnostics.Stopwatch.StartNew();
        //         for (var i = 0; i < times; ++i)
        //         {
        //             executeAlgorithm(); // Calls the action passed in to this method
        //         }

        //         sw.Stop();
        //         return sw.Elapsed.TotalMilliseconds / times;
        //     }

    }


}