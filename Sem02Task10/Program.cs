﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// Программа для реализации задачи
// Вывод сообщения для пользователя и ввод числа
int number = ReadInt("Введите трехзначное число: ");
int amount = number.ToString().Length;

// Функция проверки на соответствие условия 3-х цифр в числе
if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.Write("Второе число из трехзначного будет: ");
    Console.WriteLine(InCenter(number));
}

// Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция вывода цифры стоящей в середине 3-х значного числа
int InCenter(int a)
{
    int result = ((a / 10) % 10);
    return result;
}
