// 1. Напишите программу, которая принимает на вход
//    пятизначное число и проверяет, является ли оно палиндромом.

void Pali(int num)
{
    int num_1_2 = num / 1000;
    int num_5 = num % 10;
    int num_4 = num / 10 % 10;

    if (num_1_2 == num_5 * 10 + num_4)
        Console.WriteLine($"Yes, {num} is a palindrome");
    else
        Console.WriteLine($"No, {num} is not a palindrome");
}

Console.WriteLine("Enter a five-digit number ");
int val = int.Parse(Console.ReadLine()!);

Pali(val);

// ------------------------- 2 вариант


string Palindrome(int n)
{
    int num = 10000;
    if (n > 100000 || n < 10000)
        return "The number is not five-digit!";
    while (num > 1)
    {
        if (n / num % 10 != n % 10)
            return "no";
        n /= 10;
        num /= 100;
    }
    return "yes";
}

Console.WriteLine(Palindrome(int.Parse(Console.ReadLine()!)));



string Palindrome(int n)
{
    int num = 10000;
    if (n > 100000 || n < 10000)
        return "The number is not five-digit!";
    while (num > 1)
    {
        if (n / num % 10 != n % 10)
            return "no";
        n /= 10;
        num /= 100;
    }
    return "yes";
}

Console.WriteLine(Palindrome(int.Parse(Console.ReadLine()!)));


// Через строки

void Palindrome_1(int n)
{
    int i = 0;
    string num = n.ToString();
    int size = num.Length - 1;
    string flag = "yes";

    while (i < size / 2)
    {
        if (num[i] != num[size - i])
        {
            flag = "no";
            break;
        }
        i += 1;
    }
    Console.WriteLine($"{n} -> {flag}");
}

Palindrome_1(14212);
Palindrome_1(23432);
Palindrome_1(12821);
Palindrome_1(1248421);
Palindrome_1(12488421);

