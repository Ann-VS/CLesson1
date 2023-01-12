/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число: ");
string num1 = Console.ReadLine() ?? "";
int first = Convert.ToInt32(num1);

Console.WriteLine("Введите второе число: ");
string num2 = Console.ReadLine() ?? "";
int second = Convert.ToInt32(num2);

if (first > second)
{
    Console.WriteLine($"Первое число {first} больше чем второе число {second}");
} 
else
Console.WriteLine($"Первое число {first} меньше чем второе число {second}");
