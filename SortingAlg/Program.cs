// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics;


DateTime start = DateTime.Now;

double sum = 0;

for (int i = 0; i < 1000; i += 1)
{
    for (int j = 0; j < 1000; j += 1)
    {
        for (int k = 0; k < 1000; k += 1)
        {
            sum += 1.5;
        }
    }
}
   
DateTime end = DateTime.Now;
TimeSpan s = end - start;
Console.WriteLine(sum);
Console.WriteLine(s.TotalMilliseconds + " ms");