//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

void FirstLast(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    int minRowSum = int.MaxValue, indexMinRow = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
            rowSum += arr[i, j];

        if (rowSum < minRowSum)
        {
            minRowSum = rowSum;
            indexMinRow = i;
        }
    }

    Console.WriteLine("Строка с минимальной суммой элементов");
    for (int j = 0; j < arr.GetLength(1); j++)
        Console.Write(arr[indexMinRow, j] + "\t");

}
Console.Write("Введите количество строк: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Min значение в массиве:");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Max значение в массиве:");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);

Print(mass);
FirstLast(mass);
//Print(mass);
