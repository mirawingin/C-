
// Семинар 7. Рекурсия
// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание;
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9

int SumDigit(int value)
{
    if (value == 0)
    {
        return 0;
    }
    int sum = value % 10 + SumDigit(value / 10);
    return Math.Abc(value: sum);
}
System.Console.WriteLine(value: $"Ввидите число");
int n = Convert.ToInt32(value: Console.ReadLine()!);
System.Console.WriteLine(value: SumDigit(value: n));