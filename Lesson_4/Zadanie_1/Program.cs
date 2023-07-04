// 1. Напишите программу, которая принимает
//    на вход число и выдаёт количество цифр в числе.

// 1 вариант

int NumCount_1(ulong num)
{
    int res = 0;

    for (int result = 1; num > 0; result++)
    {
        num /= 10;
        res = result;
    }
    return res;
}

Console.WriteLine("Введите число:");
ulong answer = ulong.Parse(Console.ReadLine()!);
Console.WriteLine(NumCount_1(answer));

// 2 вариант

int NumCount_2(long num)
{
    int result = 0;

    while (num > 0)
    {
        num /= 10;
        result += 1;
    }
    return result;
}

Console.WriteLine(NumCount_2(long.Parse(Console.ReadLine()!)));

// 3 вариант

int NumCount_3(int num)
{
    string result = num.ToString();
    return result.Length;
}

Console.WriteLine(NumCount_3(int.Parse(Console.ReadLine()!)));

