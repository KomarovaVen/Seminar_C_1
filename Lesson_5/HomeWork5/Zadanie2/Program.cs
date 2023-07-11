// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0

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

void ChisloNeChetnoe(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i += 2)
    {
        if (arr[i] % 2 == 0)
            count += arr[i];
    }
    Console.Write(count);
}

Console.WriteLine("Задайте размерность массива ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте начальный 3-х значный диапозон массива ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте кнечный 3-х значный диапозон массива ");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
ChisloNeChetnoe(mass);
