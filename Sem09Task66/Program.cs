// Задача 66
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine($" ");
Console.Write("Уважаемый, введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("А теперь, введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

SumFromMToN(m, n);

// Вызов функции "сумма чисел от M до N"
void SumFromMToN(int m, int n)
{
    Console.Write($"Сумма натуральных чисел будет: ");
    Console.Write(SumMN(m - 1, n));    
}

// Функция суммы чисел от M до N
int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}