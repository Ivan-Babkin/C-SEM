// Задача 38
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

Console.WriteLine(" ");
int size = ReadInt("Введите размерность массива: ");
int min = ReadInt("Введите MIN (минимальное) число массива: ");
int max = ReadInt("Введите MAX (максимальное) число массива: ");
int [] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int maxFillarray = numbers[0];
int minFillarray = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > maxFillarray)
    {
        maxFillarray = numbers[i];
    }
    if (numbers[i] < minFillarray)
    {
        minFillarray = numbers[i];
    }
}
Console.WriteLine($"Разница между MAX (максимальным) и MIN (минимальным) числом: {maxFillarray - minFillarray}");
Console.WriteLine(" ");

// Методы
void FillArrayRandomNumbers(int [] array) //Заполнение массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void PrintArray(int[] array) //Вывод массива на экран
{
    Console.Write($"Получаем вот такой массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)  //Функция ввода
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}