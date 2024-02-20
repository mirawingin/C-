// Задача 1: 
// Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

/*void PrintRange(int n, int m = 1)
{
    if (m > n)
    {
        System.Console.WriteLine();
        return;
    }
    System.Console.Write($"{m} ");
    PrintRange(n, m + 1);
}
PrintRange(5);
PrintRange(12);*/

// Задача 2: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

/*public class Program
{
    public static int AckermannFunction(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return AckermannFunction(m - 1, 1);
        else
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }

    public static void Main(string[] args)
    {
        // Пример вызова функции Аккермана для чисел m и n
        Console.WriteLine(AckermannFunction(3, 11)); // Пример вывода результата
    }
}*/

// Код реализует функцию Аккермана с использованием рекурсии. 
// Функция Аккермана обычно определена как: 
// A(m, n) = n + 1, если m = 0
// A(m, n) = A(m - 1, 1), если m > 0, n = 0
// A(m, n) = A(m - 1, A(m, n - 1)), если m > 0, n > 0
// В приведенном коде, когда функция вызывается с аргументами (m, n), она рекурсивно
// вызывает себя, чтобы вычислить значение функции Аккермана для меньших значений m и n,
// пока не достигнет базового случая.

// Задача 3: 
// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

public class Solution
{
    public static void PrintArrayReversed(int[] arr, int index)
    {
        if (index < 0 || index >= arr.Length)
            return;

        // Рекурсивный вызов функции для вывода элементов массива в обратном порядке
        PrintArrayReversed(arr, index + 1);
        Console.Write(arr[index] + " ");
    }

    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        PrintArrayReversed(array, 0); // Начинаем с индекса 0
    }
}
