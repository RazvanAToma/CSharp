// See https://aka.ms/new-console-template for more information


using System;
using System.Collections;
using System.Collections.Immutable;
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

//int[] listeAvTall = new int[5];

//listeAvTall[0] = 1;
//listeAvTall[1] = 2;
//listeAvTall[2] = 3;
//listeAvTall[3] = 4;
//listeAvTall[4] = 5;

//foreach (int number in listeAvTall)
//{
//Console.WriteLine(number);
//}


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

//int[] numList = new int[3];
//numList[0] = 5;
//numList[1] = 10;
//numList[2] = 0;

//double average(System.Int32[] list)
//{
//    int sum = 0;

//    foreach(int number in list)
//    {
//        sum += number;
//    }

//    return sum / list.Length;


//Console.WriteLine(average(numList));



// Oppgave 9

//static System.Int32[] sortList(System.Int32[] list)
//{
//    Array.Sort(list);
//    return list;
//}

//foreach(int number in sortList(numList))
//{
//    Console.WriteLine(number);
//}



// Oppgave 10

//Console.WriteLine(numList.Max());
//Console.WriteLine(numList.Min());
//Console.WriteLine(numList.Sum());



// Oppgave 11

//static int returnMin(System.Int32[] list)
//{
//    return list.Min();
//}

//Console.WriteLine(returnMin(numList));



//// Oppgave 12

//static int returnMax(System.Int32[] list)
//{
//    return list.Max();
//}

//Console.WriteLine(returnMax(numList));




// Lister (list)
// Teori

//List<string> fisker = new List<string>();

//fisker.Add("Makrell");
//fisker.Add("Laks");
//fisker.Add("Orret");

//foreach(string fisk in fisker)
//{
//    Console.WriteLine(fisk);
//}


//List<int> tallListe = new List<int>();

//for (int i = 0; i < 100; i += 1)
//{
//    tallListe.Add(i);
//}

//foreach(int tall in tallListe)
//{
//    Console.WriteLine(tall);
//}



// Oppgaver

// Oppgave 1

//List<int> oneToFive = new List<int>();

//for (int i = 1; i < 6; i += 1)
//{
//    oneToFive.Add(i);
//}

//foreach (int i in oneToFive)
//{
//    Console.WriteLine(i);
//}



// Oppgave 2

//List<int> oneToFifty = new List<int>();

//for (int i = 1; i < 51; i += 1)
//{
//    oneToFifty.Add(i);
//}

//foreach (int number in oneToFifty)
//{
//    Console.WriteLine(number);
//}



// Oppgave 3

//List<int> first100Odd = new List<int>();

//for (int i = 1; i <= 200; i += 2)
//{
//    first100Odd.Add(i);
//}

//foreach (int number in first100Odd)
//{
//    Console.WriteLine(number);
//}



// Oppgave 4

//List<double> first20Squared = new List<double>();

//for (int i = 1; i <= 20; i += 1)
//{
//    first20Squared.Add(Math.Pow(i, 2));
//}

//foreach (double number in first20Squared)
//{
//    Console.WriteLine(number);
//}



// Oppgave 5

//List<double> first15Cubed = new List<double>();

//for (int i = 1; i <= 15; i += 1)
//{
//    first15Cubed.Add(Math.Pow(i, 3));
//}

//foreach (double number in first15Cubed)
//{
//    Console.WriteLine(number);
//}



// Oppgave 6

//List<int> first10Int = new List<int>();

//for (int i = 1; i <= 10; i += 1)
//{
//    first10Int.Add(i);
//}

//foreach (int number in first10Int)
//{
//    Console.WriteLine(number);
//}



// Oppgave 7

//List<string> favFruit = new List<string>();

//favFruit.Add("Eple");
//favFruit.Add("Banan");
//favFruit.Add("Vannemelon");
//favFruit.Add("Druer");
//favFruit.Add("Fersken");

//foreach (string fruit in favFruit)
//{
//    Console.WriteLine(fruit);
//}



// Oppgave 8

//static double returnAvg(List<int> list)
//{
//    return (list.Sum() / list.Count());
//}

//List<int> numberList = new List<int>();
//numberList.Add(0);
//numberList.Add(5);
//numberList.Add(10);

//Console.WriteLine(returnAvg(numberList));



//Oppgave 9

//List<char> first10Letters = new List<char>();

//first10Letters.Add('a');
//first10Letters.Add('b');
//first10Letters.Add('c');
//first10Letters.Add('d');
//first10Letters.Add('e');
//first10Letters.Add('f');
//first10Letters.Add('g');
//first10Letters.Add('h');
//first10Letters.Add('i');
//first10Letters.Add('j');

//foreach (char letter in first10Letters)
//{
//    Console.WriteLine(letter);
//}



// Oppgave 10

//List<int> userNums = new List<int>();

//for (int i = 0; i < 5; i += 1)
//{
//    Console.Write($"Num {i}:");
//    int num = int.Parse(Console.ReadLine());

//    userNums.Add(num);
//}

//foreach (int num in userNums)
//{
//    Console.WriteLine(num);
//}



// Oppgave 11

//Random rnd = new Random();

//List<double> random8Nums = new List<double>();

//for (int i = 0; i < 8; i += 1)
//{
//    random8Nums.Add(rnd.NextDouble());
//}

//foreach (double rndNum in random8Nums)
//{
//    Console.WriteLine(rndNum);
//}



// Oppgave 12

//List<int> oneToFive = new List<int>();
//oneToFive.Add(1);
//oneToFive.Add(2);
//oneToFive.Add(3);
//oneToFive.Add(4);
//oneToFive.Add(5);

//List<int> oneToTen = new List<int>();
//oneToFive.Add(6);
//oneToFive.Add(7);
//oneToFive.Add(8);
//oneToFive.Add(9);
//oneToFive.Add(10);


//static List<int> combineLists(List<int> list1, List<int> list2)
//{
//    List<int> combinedList = new List<int>();

//    foreach (int number in list1) {combinedList.Add(number);}

//    foreach (int number in list2) {combinedList.Add(number);}

//    return combinedList;
//}

//foreach (int num in combineLists(oneToFive, oneToTen))
//{
//    Console.WriteLine(num);
//}



// Oppgave 13

//List<string> countries = new List<string>();
//countries.Add("Norway");
//countries.Add("Germany");
//countries.Add("Italy");
//countries.Add("Romania");
//countries.Add("Russia");
//countries.Add("France");
//countries.Add("Spain");
//countries.Add("Portugal");
//countries.Add("Hungary");
//countries.Add("Switzerland");


//int findIndexOf(string countryName)
//{
//    return countries.IndexOf(countryName);
//}


//Console.WriteLine("What country are you looking for?");
//string country = Console.ReadLine();

//if (countries.Contains(country))
//{
//    Console.WriteLine($"{country} has the index of: {findIndexOf(country)}");
//}
//else
//{
//    Console.WriteLine($"{country} is not in list...");
//}


// Dictionary / Ordboker / Hashtables

// Teori
//Dictionary<string, string> keyValuePair = new Dictionary<string, string>();
//keyValuePair.Add("Razvan", "Toma");
//keyValuePair.Add("Kjeld", "Berg");

//Console.WriteLine($"Etternavnet til Razvan er {keyValuePair["Razvan"]}");

//Dictionary<string, int> keyValuePair1 = new Dictionary<string, int>();
//keyValuePair1.Add("Razvan", 2006);
//keyValuePair1.Add("Kjeld", 1983);

//foreach (KeyValuePair<string, string> entry in keyValuePair)
//{
//    Console.WriteLine($"Navn: {entry.Key}\nEtternavn: {entry.Value}");
//}

//foreach (KeyValuePair<string, int> entry in keyValuePair1)
//{
//    Console.WriteLine($"Navn: {entry.Key}\nAar: {entry.Value}");
//}



// Oppgaver

// Oppgave 3

//Dictionary<int, string> tallTilTekst = new Dictionary<int, string>();

//tallTilTekst.Add(1, "en");
//tallTilTekst.Add(2, "to");
//tallTilTekst.Add(3, "tre");
//tallTilTekst.Add(4, "fire");
//tallTilTekst.Add(5, "fem");
//tallTilTekst.Add(6, "seks");
//tallTilTekst.Add(7, "sju");
//tallTilTekst.Add(8, "aatte");
//tallTilTekst.Add(9, "ni");
//tallTilTekst.Add(10, "ti");

//foreach(KeyValuePair<int, string> entry in tallTilTekst)
//{
//    Console.WriteLine($"{entry.Key} | {entry.Value}");
//}

//Console.WriteLine("Skriv et tall mellom 0 og 11");
//int userNum = int.Parse(Console.ReadLine());

//Console.WriteLine($"{userNum} --> {tallTilTekst[userNum]}");



// Oppgave 4

//Dictionary<char, char> stringEncryptionDict = new Dictionary<char, char>();
//stringEncryptionDict.Add('a', 'c');
//stringEncryptionDict.Add('b', 'd');
//stringEncryptionDict.Add('c', 'e');
//stringEncryptionDict.Add('d', 'f');
//stringEncryptionDict.Add('e', 'g');
//stringEncryptionDict.Add('f', 'h');
//stringEncryptionDict.Add('g', 'i');
//stringEncryptionDict.Add('h', 'j');
//stringEncryptionDict.Add('i', 'k');
//stringEncryptionDict.Add('j', 'l');
//stringEncryptionDict.Add('k', 'm');
//stringEncryptionDict.Add('l', 'n');
//stringEncryptionDict.Add('m', 'o');
//stringEncryptionDict.Add('n', 'p');
//stringEncryptionDict.Add('o', 'q');
//stringEncryptionDict.Add('p', 'r');
//stringEncryptionDict.Add('q', 's');
//stringEncryptionDict.Add('r', 't');
//stringEncryptionDict.Add('s', 'u');
//stringEncryptionDict.Add('t', 'v');
//stringEncryptionDict.Add('u', 'w');
//stringEncryptionDict.Add('v', 'x');
//stringEncryptionDict.Add('w', 'y');
//stringEncryptionDict.Add('x', 'z');
//stringEncryptionDict.Add('y', 'a');
//stringEncryptionDict.Add('z', 'b');

//string rawStr = "password";


//string encrypter(string str)
//{
//    string encryptedStr = "";

//    foreach (char character in str)
//    {
//        encryptedStr += stringEncryptionDict[character];
//    }

//    return encryptedStr;
//}

//Console.WriteLine(rawStr);
//Console.WriteLine(encrypter(rawStr));



// Oppgave 5

