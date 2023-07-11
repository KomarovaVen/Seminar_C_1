// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double[] MassNums(int size, int from, int to)
{
    double[] arr = new double[size];
    Random n_new = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(n_new.NextDouble() * (to - from) + from, 2);
    }
    return arr;
}

void ChisloRaznica(double[] arr)
{
    double n_max = arr[0];
    double n_min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (n_max < arr[i])
            n_max = arr[i];
    }
    Console.Write($"Max:{n_max}, min: {n_min}. ");
    Console.WriteLine($"Raznica:{n_max} - ({n_min}) = {Math.Round(n_max - n_min)}");
}

Console.WriteLine("Задайте размерность массива ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте начальный 3-х значный диапозон массива ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте кнечный 3-х значный диапозон массива ");
int stop = int.Parse(Console.ReadLine()!);

double[] mass = MassNums(num, start, stop);
Print(mass);
ChisloRaznica(mass);