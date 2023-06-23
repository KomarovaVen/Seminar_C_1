// 0. Напишите программу, которая на вход принимает число и
//    выдаёт его квадрат (число умноженное на само себя).


Console.WriteLine("Введите значение: ");
string num_str = Console.ReadLine()!;

int num = int.Parse(num_str);

Console.WriteLine(num * num);
