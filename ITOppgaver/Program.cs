// See https://aka.ms/new-console-template for more information


using System;


static double arealSirkel(int radius)
{
    double areal = Math.PI * Math.Pow(radius, 2);
    return areal;
}

Console.WriteLine(arealSirkel(24));
Console.WriteLine(arealSirkel(32));


static double volumKule(int radius)
{
    double volum = 4/3 * Math.PI * Math.Pow(radius, 2);
    return volum;
}

Console.WriteLine($"Volumet av kula er {volumKule(11)}");
Console.WriteLine($"Volumet av kula er {volumKule(21)}");