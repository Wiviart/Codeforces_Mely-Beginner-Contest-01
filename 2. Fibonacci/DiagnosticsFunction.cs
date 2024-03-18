using System.Diagnostics;

public class DiagnosticsFunction
{
    static Stopwatch stopwatch;
    static long memoryUsedBefore;
    public static void Start()
    {
        stopwatch = new Stopwatch();
        stopwatch.Start();

        memoryUsedBefore = GC.GetTotalMemory(true);
    }

    public static void End()
    {
        stopwatch.Stop();
        Console.WriteLine($"Elapsed time: {stopwatch.ElapsedMilliseconds / 1000} seconds");

        long memoryUsed = GC.GetTotalMemory(true);
        Console.WriteLine($"Memory used: {(memoryUsed - memoryUsedBefore) / 1000} KB");
    }
}