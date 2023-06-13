using System;
using System.IO;
using System.Text;

namespace Number.String.Sorter;

public class NumberStringSorter
{
    public static void ReadFile(string filePath)
    {
        const int bufferSize = 8192; // or another size you determine is optimal
        using var sr = new StreamReader(filePath, Encoding.UTF8, true, bufferSize);
        
        while (sr.ReadLine() is { } line)
        {
            Console.WriteLine(line);
        }
    }
}