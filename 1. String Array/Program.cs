class Program
{
    static string GetValidString(string name)
    {
        string strg = "";
        while (strg.Length < 1 || strg.Length > Math.Pow(10, 5))
        {
            // Console.WriteLine($"Enter string {name}: ");
            strg = Console.ReadLine();
        }

        return strg;
    }

    public static bool IsSubsequence(string a, string b)
    {
        if (a == b) return false;

        char[] aArray = a.ToCharArray();
        char[] bArray = b.ToCharArray();
        int indexA = 0;
        int indexB = 0;

        while (indexB < bArray.Length)
        {
            if (indexA >= aArray.Length)
            {
                return true;
            }

            if (aArray[indexA] == bArray[indexB])
            {
                indexA++;
                indexB++;
            }
            else
            {
                indexB++;
            }

            if (indexA >= aArray.Length && indexB >= bArray.Length)
            {
                return true;
            }
        }

        return false;
    }

    static void Main()
    {
        string a = GetValidString("A");
        string b = GetValidString("B");

        if (IsSubsequence(a, b))
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}

class Tester
{
    public static void Test()
    {
        string[] c = { "abc", "abcd", "abdssc", "acbd", "aassdb", "oojojac", "oookaijbkkc" };

        string a = "abc";
        foreach (var x in c)
        {
            string b = x;

            if (Program.IsSubsequence(a, b))
            {
                Console.WriteLine($"YES = {a} <= {b}");
            }
            else
            {
                Console.WriteLine($"NO  = {a} <= {b}");
            }
        }
    }
}
