using System.Diagnostics;
using System.Text;

class Program
{
    static uint Fibonacci(uint a, uint b, uint n)
    {
        if (n == 0) return a;
        if (n == 1) return b;

        uint fibMinus2 = a,
            fibMinus1 = b,
            fib = 0;

        for (int i = 2; i <= n; i++)
        {
            fib = fibMinus1 ^ fibMinus2;
            fibMinus2 = fibMinus1;
            fibMinus1 = fib;
        }

        return fib;
    }

    static string FibonacciCalculator(string testcase)
    {
        string[] input = testcase.Split(' ');
        uint a = uint.Parse(input[0]);
        uint b = uint.Parse(input[1]);
        uint n = uint.Parse(input[2]);

        var r = Fibonacci(a, b, n);

        return r.ToString();
    }

    static void Main()
    {
        ushort number = ushort.Parse(Console.ReadLine());

        string[] testcase = new string[number];

        for (ushort i = 0; i < number; i++)
        {
            testcase[i] = Console.ReadLine();
        }

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        long memoryUsedBefore = GC.GetTotalMemory(true);

        for (int i = 0; i < testcase.Length; i++)
        {
            var result = FibonacciCalculator(testcase[i]);
            Console.WriteLine(result);
        }
        // var result = Test();


        stopwatch.Stop();
        Console.WriteLine($"Elapsed time: {stopwatch.ElapsedMilliseconds / 1000} seconds");

        long memoryUsed = GC.GetTotalMemory(true);
        Console.WriteLine($"Memory used: {(memoryUsed - memoryUsedBefore) / 1000} KB");
    }

    static bool IsValid(int number, int min, int pow)
    {
        if (number < min || number > Math.Pow(10, pow))
        {
            return false;
        }
        return true;
    }

    static string Test(int i)
    {
        string[] testcase =
        {
            "3 5 2",
            "7 3 0",
            "191 325 123548",
            "5 12 98",
            "8765 1232 12323",
            "54 12 9480",
            "876 134 5554"
        };

        return FibonacciCalculator(testcase[i]);
    }


}

