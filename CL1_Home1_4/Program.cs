/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число: ");
string num1 = Console.ReadLine() ?? "";
int first = Convert.ToInt32(num1);

Console.WriteLine("Введите второе число: ");
string num2 = Console.ReadLine() ?? "";
int second = Convert.ToInt32(num2);

Console.WriteLine("Введите третье число: ");
string num3 = Console.ReadLine() ?? "";
int third = Convert.ToInt32(num3);

if (first > second)
{
    if (first > third)
    {
        Console.WriteLine($"Максимальное число = {first}");
    }
    else
        Console.WriteLine($"Максимальное число = {third}");
}
else
{
    if (second > third)
    {
        Console.WriteLine($"Максимальное число = {second}");
    }
    else
        Console.WriteLine($"Максимальное число = {third}");
}