using System.Diagnostics;

class Program
{
    static void Main()
    {
        // Input
        int caseCount = int.Parse(Console.ReadLine());
        int[] numbers = new int[caseCount];
        int max = 0;

        for (int i = 0; i < caseCount; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            if (numbers[i] > max)
                max = numbers[i];
        }

        max *= 2;

        // Diagnostic Tools start
        DiagnosticsFunction.Start();

        // Calculation and Output
        HashSet<int> primes = GetPrimeNumbers(max);

        for (int i = 0; i < caseCount; i++)
        {
            int prime = GetPrimeNumberToSum(primes, numbers[i]);
            Console.WriteLine(prime);
        }

        // Diagnostic Tools end
        DiagnosticsFunction.End();
    }

    static int GetPrimeNumberToSum(HashSet<int> primes, int n)
    {
        HashSet<int> primeToSum = new HashSet<int>();

        foreach (int i in primes)
        {
            if (primes.Contains(n + i))
                continue;

            primeToSum.Add(i);
        }

        Random random = new Random();
        int index = random.Next(0, primeToSum.Count);
        return primeToSum.ElementAt(index);
    }

    static HashSet<int> GetPrimeNumbers(int n)
    {
        HashSet<int> primes = new HashSet<int>() { 2, 3 };

        for (int i = 4; i < n; i++)
        {
            foreach (int prime in primes)
            {
                int j = 0;
                if (i % prime == 0)
                {
                    j++;
                    break;
                }
                else if (j == primes.Count - 1)
                {
                    primes.Add(i);
                }
            }
        }

        return primes;
    }
}
