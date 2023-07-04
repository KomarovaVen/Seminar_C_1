<<<<<<< HEAD
﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432->да


{
    int num, r, sum = 0, t;


    Console.Write("\n\n");
    Console.Write("Check whether a number is a palindrome or not:\n");
    Console.Write("------------------------------------------------");
    Console.Write("\n\n");
    Console.Write("Input a number: ");
    num = Convert.ToInt32(Console.ReadLine());
    for (t = num; num != 0; num = num / 10)
    {
        r = num % 10;
        sum = sum * 10 + r;
    }
    if (t == sum)
        Console.Write("{0} is a palindrome number.\n", t);
    else
        Console.Write("{0} is not a palindrome number.\n", t);
=======
﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432->да


{
    int num, r, sum = 0, t;


    Console.Write("\n\n");
    Console.Write("Check whether a number is a palindrome or not:\n");
    Console.Write("------------------------------------------------");
    Console.Write("\n\n");
    Console.Write("Input a number: ");
    num = Convert.ToInt32(Console.ReadLine());
    for (t = num; num != 0; num = num / 10)
    {
        r = num % 10;
        sum = sum * 10 + r;
    }
    if (t == sum)
        Console.Write("{0} is a palindrome number.\n", t);
    else
        Console.Write("{0} is not a palindrome number.\n", t);
>>>>>>> d1c5ef0435e4b5f475940aa0cbd930175618de1f
}