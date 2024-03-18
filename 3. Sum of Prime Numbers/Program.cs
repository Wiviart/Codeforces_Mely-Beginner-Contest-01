class Program
{
    static bool IsPrime(int n)
    {
        if (n <= 1) return false;

        if (n == 2 || n == 3) return true;

        if (n % 2 == 0 || n % 3 == 0) return false;

        for (int i = 5; i <= Math.Sqrt(n); i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0)
                return false;
        }

        return true;
    }

    // Function to find the prime number m such that m + n is not prime
    static int FindPrimeM(int n)
    {
        int m = 2;
        while (true)
        {
            if (!IsPrime(m + n))
                return m;
            m++;
        }
    }

    static void Main()
    {
        // Input
        int t = int.Parse(Console.ReadLine()); // Number of test cases
        int[] numbers = new int[t];

        for (int i = 0; i < t; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine()); // Prime number n for each test case
        }

        // Output 
        for (int i = 0; i < t; i++)
        {
            Console.WriteLine(FindPrimeM(numbers[i]));
        }

        // for (int i = 0; i < 1000; i++)
        // {
        //     if (IsPrime(i))
        //         Console.Write($"{i} ");
        // }
    }
}
