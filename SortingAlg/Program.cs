// See https://aka.ms/new-console-template for more information

using System.Diagnostics;


Stopwatch sw = new Stopwatch();


static Array createRandArr()
{
    Random random = new Random();

    int[] randArray = new int[10];

    int currentIndex = 0;

    for (int i = 0; i < 10; i += 1)
    {
        randArray[currentIndex++] = random.Next(10);
    }

    return randArray;
}

Array randArray = createRandArr();

foreach(int num in randArray)
{
    Console.WriteLine(num);
}
Console.WriteLine("-");

//foreach(int number in randArray)
//{
//    int currentIndex = 0;

//    if (number > randArray[currentIndex + 1])
//    {
//        Console.WriteLine($"{number} is bigger than {randArray[currentIndex + 1]}");
//    }
//}

int index = 0;
Console.WriteLine(randArray[index]);