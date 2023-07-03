// 1. Напишите программу, которая принимает на вход координаты точки (X и Y),
//    причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости,
//    в которой находится эта точка.

void Quarters(int x, int y)
{
    if (x == 0 || y == 0)
        Console.WriteLine("x = 0 or y = 0");
    else if (x > 0 && y > 0)
        Console.WriteLine("I");
    else if (x < 0 && y > 0)
        Console.WriteLine("II");
    else if (x < 0 && y < 0)
        Console.WriteLine("III");
    else if (x > 0 && y < 0)
        Console.WriteLine("IV");
}

Console.WriteLine("Введите координату X:");
int num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y:");
int num_2 = int.Parse(Console.ReadLine()!);
Quarters(num_1, num_2);

/*

void Quarters(int x, int y)
{
    if (x > 0)
    {
        if (y > 0)
        {
            Console.WriteLine("First quarter - I");
        }
        else if (y < 0)
        {
            Console.WriteLine("Fourth quarter - IV");
        }
    }
    else if (x < 0)
    {
        if (y > 0)
        {
            Console.WriteLine("Second quarter - II");
        }
        else if (y < 0)
        {
            Console.WriteLine("Third quarter - III");
        }
    }
}

Quarters(2, 2);
Quarters(-2, 2);
Quarters(-2, -2);
Quarters(2, -2);
*/
// 1. Напишите программу, которая по заданному номеру четверти,
//    показывает диапазон возможных координат точек в этой четверти (x и y).

void Coordinates(string num)
{
    if (num == "I")
    {
        Console.WriteLine("x > 0, y > 0");
    }
    else if (num == "II")
    {
        Console.WriteLine("x < 0, y > 0");
    }
    else if (num == "III")
    {
        Console.WriteLine("x < 0, y < 0");
    }
    else if (num == "IV")
    {
        Console.WriteLine("x > 0, y < 0");
    }
    else
    {
        Console.WriteLine("The data is not correct!");
    }
}

string num = Console.ReadLine()!;
Coordinates(num);