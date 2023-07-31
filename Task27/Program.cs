// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int sum = SumOfDigits(number);

Console.WriteLine($"Сумма цифр числа {number} равна: {sum}");

int SumOfDigits(int number)
{
    int sum = 0;
    int tempNumber = number;

    while (tempNumber > 0)
    {
        int digit = tempNumber % 10;
        sum += digit;
        tempNumber /= 10;
    }

    return sum;
}