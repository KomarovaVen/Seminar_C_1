// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

void ArrRev(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size / 2; i++)
        (arr[i], arr[size - i - 1]) = (arr[size - i - 1], arr[i]);

}

Console.WriteLine("Задайте размерность массива ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте начальный  диапозон массива ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте кнечный диапозон массива ");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
ArrRev(mass);
Print(mass);