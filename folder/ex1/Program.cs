﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.Write("Введите число: ");
string? numbsMass = Console.ReadLine();
int length = numbsMass.Length;

if (length == 5)
{
    if (Convert.ToInt32(numbsMass[0]) == Convert.ToInt32(numbsMass[4]))
    {
        if (Convert.ToInt32(numbsMass[1]) == Convert.ToInt32(numbsMass[3]))
        {
            System.Console.WriteLine("Да!");
        }
        else
        {
            System.Console.WriteLine("Некорректное число");
        }
    }
    else
    {
        System.Console.WriteLine("Некорректное число");
    }
}
else
{
    System.Console.WriteLine("Некорректное число");
}