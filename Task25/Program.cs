// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A:");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень B:");
int B = Convert.ToInt32(Console.ReadLine());

int result = CalculatePower(A, B);

Console.WriteLine($"Результат: {result}");

int CalculatePower(int baseNumber, int exponent)
{
    int result = 1;
    for (int i = 1; i <= exponent; i++)
    {
        result *= baseNumber;
    }
    return result;
}