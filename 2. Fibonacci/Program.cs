using System.Diagnostics;

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

    static void Main()
    {
        ushort number = 0;

        while (!IsValid(number, 1, 3))
            number = ushort.Parse(Console.ReadLine());

        uint[][] testcase = new uint[number][];

        for (ushort i = 0; i < number; i++)
        {
            testcase[i] = Array.ConvertAll(Console.ReadLine().Split(' '), uint.Parse);

            if (!IsValid(testcase[i][0], 0, 9) || !IsValid(testcase[i][1], 0, 9) || !IsValid(testcase[i][2], 0, 9))
            {
                i--;
                continue;
            }
        }

        DiagnosticsFunction.Start();

        for (int i = 0; i < testcase.Length; i++)
        {
            var result = Fibonacci(testcase[i][0], testcase[i][1], testcase[i][2]);
            Console.WriteLine(result);
        }

        DiagnosticsFunction.End();
    }

    static bool IsValid(uint number, uint min, int pow)
    {
        if (number < min || number > Math.Pow(10, pow))
        {
            return false;
        }
        return true;
    }
}

