// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics;


Stopwatch sw = new Stopwatch();


sw.Start();

int sum = 0;

int reps = 2000;

for (int a = 1; a < reps; a += 1)
{
    for (int b = 1; b < reps; b += 1)
    {
        for (int c = 1; c < reps; c += 1)
        {
            sum += 1;
        }
    }
}

sw.Stop();

Console.WriteLine(sum);

Console.WriteLine(sw.Elapsed);