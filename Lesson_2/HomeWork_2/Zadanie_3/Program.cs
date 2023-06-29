//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Chislo(int num)
{
    Console.WriteLine(num);

    if (num > 999)

    { num /= 10; };

    { return num % 10; };

    if (num > 100)

    { return num; };
}


int result = Chislo(new Random().Next(100, 1000));
Console.WriteLine(result);