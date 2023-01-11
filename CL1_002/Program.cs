/*
Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет
*/

Console.WriteLine("Введите первое число: ");
string input0 = Console.ReadLine() ?? "";

Console.WriteLine("Введите второе число: ");
string input1 = Console.ReadLine() ?? "";

int num0 = Convert.ToInt32(input0);
int num1 = Convert.ToInt32(input1);

if ((num1 * num1) == num0) 
{
    Console.WriteLine($"Да, {num0} является квадратом {num1}");
}
else
{
    Console.WriteLine($"Нет, {num0} не является квадратом {num1}");
}