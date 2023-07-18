// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to + 1);
    }
    return arr;
}

void Chislo(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            count = +arr[i];
    }
    Console.Write($"Чисел больше 0:{count}");
}

Console.WriteLine("Задайте размерность массива ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте начальный диапозон массива ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте кнечный диапозон массива ");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
Chislo(mass);

