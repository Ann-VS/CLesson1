/*
Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/

Console.WriteLine("Введите число: ");
string num = Console.ReadLine() ?? "";
int n = Convert.ToInt32(num);

if ((n>=100) && (n<=999))
    Console.WriteLine(n % 10);
else
    Console.WriteLine("Неверно введенное число");