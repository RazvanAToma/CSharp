// See https://aka.ms/new-console-template for more information


using System;
using System.Reflection.Metadata;


static double arealSirkel(int radius)
{
    double areal = Math.PI * Math.Pow(radius, 2);
    return areal;
}

//Console.WriteLine(arealSirkel(24));
//Console.WriteLine(arealSirkel(32));



static double volumKule(int radius)
{
    double volum = 4/3 * Math.PI * Math.Pow(radius, 2);
    return volum;
}

//Console.WriteLine($"Volumet av kula er {volumKule(11)}");
//Console.WriteLine($"Volumet av kula er {volumKule(21)}");



static string gammelhet(string navn, int alder)
{
    if (alder < 30)
    {
        return $"Hei {navn}, du er ung!";
    }
    else if (alder > 30)
    {
        return $"Hei {navn}, du er gammel!";
    }
    else
    {
        return $"Hei {navn}, du er midt i mellom...";
    }
}


//Console.WriteLine("Hva heter du?");
//string navn = Console.ReadLine();

//Console.WriteLine("Hvor gammel er du?");
//int alder = int.Parse(Console.ReadLine());

//Console.WriteLine(gammelhet(navn, alder));



static int kvadrat(int tall)
{
    return Convert.ToInt32(Math.Pow(tall, 2));
}

//int tall = 5;

//Console.WriteLine($"Kvadratet av {tall} er {kvadrat(tall)}");



static void tallSwap(int tall1, int tall2)
{
    int temp1 = tall1;
    int temp2 = tall2;

    int tall1s = temp2;
    int tall2s = temp1;

    Console.WriteLine(tall1s);
    Console.WriteLine(tall2s);
}

//tallSwap(5, 10);



static bool inRange(int tall, int minRange, int maxRange)
{
    if (tall > minRange && tall < maxRange)
    {
        return true;
    }

    return false;
}

//Console.WriteLine(inRange(7, 5, 10));





static double vectorLength(int x, int y)
{
    double lengde = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

    return lengde;
}

bool userContinue = true;

while (userContinue)
{
    Console.WriteLine("Vektor x:");
    int x = int.Parse(Console.ReadLine());

    Console.WriteLine("Vektor y:");
    int y = int.Parse(Console.ReadLine());

    Console.WriteLine(vectorLength(x, y));


    Console.WriteLine("\nContinue?");
    string userContinueString = Console.ReadLine();

    if (userContinueString == "y")
    {
        userContinue = true;
    }
    else if (userContinueString == "n")
    {
        userContinue = false;
    }

}


