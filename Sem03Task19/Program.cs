// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

void CheckPalindromicNumber(int number)
{
    if(number >= 10000)
    {
        int division1 = number / 10000;
        int remainder1 = number % 10;

            if(division1 == remainder1)
            {
                number = number / 10;
                int division2 = (number / 100) % 10;
                int remainder2 = number % 10;
                if(division2 == remainder2)
                    Console.WriteLine("ДА, число ЯВЛЯЕТСЯ палиндромом");
            }
            else 
            Console.WriteLine("НЕТ, числе ТОЧНЕ НЕ палиндром");
            
    }
    else
    Console.WriteLine("Некорректное число, подумай и запусти программу заново!!!");
}

Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine()!);
CheckPalindromicNumber(number);