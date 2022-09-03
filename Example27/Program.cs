// Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.Clear();

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
int sum = 0;
int res = 0;
int num1;

for (sum = 0; number > 0; sum += res)
{
    res = number % 10;
    number = number / 10;
}
Console.WriteLine($"Сумма цифр во введенном числе = {sum}");