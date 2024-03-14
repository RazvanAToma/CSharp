// See https://aka.ms/new-console-template for more information


using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
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

bool userContinue = false;

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



static void terningKast(int terninger, int sider)
{
    Random random = new Random();

    for (int kast = 0; kast != terninger; kast += 1)
    {
        int randomHeltall = random.Next(1, sider + 1);

        Console.WriteLine($"Du fikk {randomHeltall}");
    }
}

//terningKast(5, 6);



static void yahtzee()
{
    List<int> results = new List<int>();

    results.Add(5);
    results.Add(5);
    results.Add(5);
    results.Add(5);

    foreach (int result in results)
    {
        if (results[0] != result)
        {
            Console.WriteLine("Ingen yahtzee");
            break;
        }
        else if (results[0] == result)
        {
            Console.WriteLine("Yahtzee");
        }
    }
}

//yahtzee();



// Oppgaver Kjeld C#

// Oppgave 1
static double arealKvadrat(int side)
{
    double kvadratAreal = Math.Pow(side, 2);
    return kvadratAreal;
}

//Console.WriteLine(arealKvadrat(4));

// Oppgave 2
static double arealSirkelKjeld(double radius)
{
    double sirkelAreal = Math.PI * Math.Pow(radius, 2);
    return sirkelAreal;
}

double radius = 7.97886;

//Console.WriteLine($"Arealet til en sirkel med radius {radius} er {arealSirkelKjeld(radius)}");


// Oppgave 3
static string place(string city, string country)
{
    return $"{city} er en by i {country}";
}

//Console.WriteLine(place("Oslo", "Norge"));


// Oppgave 4
static int smallest(int num1, int num2)
{
    if (num1 > num2)
    {
        return num2;
    }

    return num1;
}

//Console.WriteLine(smallest(5, 10));


// Oppgave 5
static void topbot(string name)
{
    Console.Write("+");

    for (int i = 0; i < name.Length; i += 1)
    {
        Console.Write("-");
    }

    Console.WriteLine("+");
}

static void nametag(string name)
{
    topbot(name);

    Console.WriteLine($"|{name}|");

    topbot(name);
}

//nametag("Alexander");



// Funksjoner med returverdier

// Oppgave 1
static int smallestOfThree(int num1, int num2, int num3)
{
    if (num1 < num2 && num1 < num3)
    {
        return num1;
    }
    else if (num2 < num1 && num2 < num3)
    {
        return num2;
    }
    else
    {
        return num3;
    }
}

//Console.WriteLine(smallestOfThree(9, 7, 1));


// Oppgave 2
static void overflateAreal(string geometriskFigur)
{
    if (geometriskFigur == "kule")
    {
        Console.WriteLine("Kule");
    }
    else if (geometriskFigur == "sylinder")
    {
        Console.WriteLine("Sylinder");
    }
    else if (geometriskFigur == "kjegle")
    {
        Console.WriteLine("Kjegle");
    }
    else
    {
        Console.WriteLine("Ukjent geometrisk figur");
    }
}

//overflateAreal("");

// Oppgave 3

static int amount(char character, string text)
{
    int x = 0;
    
    foreach (char textChar in text)
    {
        if (textChar == character)
        {
            x += 1;
        }
    }

    return x;

}

string myText = "Jeg heter Jens og jeg er ikke hvit";

//Console.WriteLine($"Det er {amount('e', myText)} forekomster av tegnet");


// Oppgave 4

static int wordCount(string text)
{
    int count = 1;

    foreach (char textChar in text)
    {
        if (textChar == ' ')
        {
            count += 1;
        }
    }

    return count;
}

//Console.WriteLine($"Det er {wordCount(myText)} ord i \"{myText}\"");


// Oppgave 5

static bool threeValuesEqual(int num1, int num2, int num3)
{
    if (num1 == num2 && num1 == num3)
    {
        return true;
    }
    return false;
}

//Console.WriteLine(threeValuesEqual(5, 4, 5));





// Arrayer og noen forskjellige typer lister

// Oppgave 1

int[] listeAvTall = new int[5];

listeAvTall[0] = 1;
listeAvTall[1] = 2;
listeAvTall[2] = 3;
listeAvTall[3] = 4;
listeAvTall[4] = 5;

foreach (int number in listeAvTall)
{
    //Console.WriteLine(number);
}


// Oppgave 2

//int[] firstFifty = new int[50];

//int curNum = 1;

//for (int i = 0; i < 50; i += 1)
//{
//    firstFifty[i] = curNum;

//    curNum += 1;
//}

//foreach (int number in firstFifty)
//{
//    Console.WriteLine(number);
//}



// Oppgave 3

//int[] odd100 = new int[100];

//int currentIndex = 0;

//for(int i = 1; i < 200; i+= 2)
//{
//    odd100[currentIndex] = i;
//    currentIndex += 1;
//}

//foreach(int number in odd100)
//{
//    Console.WriteLine(number);
//}




// Oppgave 4

//int[] first20Squared = new int[20];

//int currentIndex = 0;

//for(int i = 1; i < 21; i += 1)
//{
//    double numDouble = Math.Pow(i, 2);
//    int numInt = Convert.ToInt32(numDouble);

//    first20Squared[currentIndex] = numInt;
//    currentIndex += 1;
//}

//foreach(int number in first20Squared)
//{
//    Console.WriteLine(number);
//}




// Oppgave 5

//int[] first15Cubed = new int[15];

//int curIndex = 0;

//for (int i = 1; i < first15Cubed.Length + 1; i += 1)
//{
//    double doubleNum = Math.Pow(i, 3);
//    int intNum = Convert.ToInt32(doubleNum);

//    first15Cubed[curIndex] = intNum;
//    curIndex += 1;
//}

//foreach(int number in first15Cubed)
//{
//    Console.WriteLine(number);
//}




// Oppgave 6

//string[] userStr = new string[5];

//for(int i = 0; i < userStr.Length; i += 1)
//{
//    Console.Write("Skriv: ");
//    string userInput = Console.ReadLine();
//    userStr[i] = userInput;
//}

//foreach(string str in userStr)
//{
//    Console.WriteLine(str);
//}



// Oppgave 7

//int[] random50nums = new int[50];

//Random random = new Random();

//for (int i = 0; i < random50nums.Length; i += 1)
//{
//    random50nums[i] = random.Next(100);
//}

//foreach(int number in random50nums)
//{
//    Console.WriteLine(number);
//}



// Oppgave 8

int[] numList = new int[3];
numList[0] = 5;
numList[1] = 10;
numList[2] = 0;

double average(System.Int32[] list)
{
    int sum = 0;

    foreach(int number in list)
    {
        sum += number;
    }

    return sum / list.Length;
}

Console.WriteLine(average(numList));