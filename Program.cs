﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
System.Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
{
    System.Console.WriteLine("Yes");
}
else
{
    System.Console.WriteLine("No");
}