// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int SumNum(int num)
{
    int all_sum = 0;
    for (int i = 1; i <= num; i++)
    {
        all_sum += num % 10;
        num /= 10;
    }
    return all_sum;
}
Console.WriteLine("Введите число:");
string answer = Console.ReadLine()!;
int ans = answer == null ? 0 : int.Parse(answer);
Console.WriteLine(SumNum(ans));

