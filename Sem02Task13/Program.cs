﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Программа для реализации задачи
// Вывод сообщения для пользователя и ввод числа
Console.Write("Введите число, чтобы найти третью цифру в нем:  ");
char[] digit = Console.ReadLine().ToCharArray();

if (digit.Length >= 3)
{
    Console.Write("Третья цифра в числе будет: ");
    Console.WriteLine(digit[2]);
}
// Выводит сообщение об отсутствии третьей цифры
else
{
    Console.WriteLine("Третьей цифры нет");
}
