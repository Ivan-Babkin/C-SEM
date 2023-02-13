// Задача 43
// Напишите программу, которая найдёт точку пересечения двух прямых заданных уравнениями:
// y = k1 * x + b1
// y = k2 * x + b2
// значения b1, k1, b2 и k2 задаются пользователем
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine(" ");
Console.WriteLine("Уважаемый, для расчета точки пересечения двух прямых, необходима Ваша помощь:");
double b1 = ReadInt("Введите значение для переменной b1: ");
double b2 = ReadInt("Введите значение для переменной b2: ");
double k1 = ReadInt("Введите значение для переменной k1: ");
double k2 = ReadInt("Введите значение для переменной k2: ");

Console.Write($"Введенные Вами значения: ");
Console.WriteLine($"({b1}:{b2}:{k1}:{k2})");

double first = (b1 - b2) / (k2 - k1);
double second = (k2 * first) + b2;

Console.Write($"Точка пересечения двух прямых имеет координаты: ");
Console.WriteLine($"({first}:{second})");
Console.WriteLine(" ");

// Метод
double ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}