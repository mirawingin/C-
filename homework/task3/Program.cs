//Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
/*while (true)
{
    Console.WriteLine("Введите целое число или 'q' для выхода:");

    // Читаем ввод пользователя
    string input = Console.ReadLine();

    // Проверяем, является ли ввод символом 'q'
    if (input.ToLower() == "q")
    {
        Console.WriteLine("Выход из программы...");
        break; // завершаем программу
    }

    // Пробуем преобразовать ввод в целое число
    if (int.TryParse(input, out int number))
    {
        // Проверяем сумму цифр числа на чётность
        if (IsEvenDigitSum(number))
        {
            Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершается.");
            break; // завершаем программу
        }
    }
    else
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q' для выхода.");
    }
}


// Функция для проверки суммы цифр числа на чётность
static bool IsEvenDigitSum(int number)
{
    int sum = 0;
    number = Math.Abs(number); // делаем число положительным

    // Считаем сумму цифр числа
    while (number > 0)
    {
        sum += number % 10; // получаем последнюю цифру числа и добавляем её к сумме
        number /= 10; // убираем последнюю цифру числа
    }

    return sum % 2 == 0; // возвращаем true, если сумма чётная, иначе false
}

Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

// Задаем размер массива
int arrayLength = 10; // например, создадим массив из 10 элементов

// Создаем массив случайных трехзначных чисел
int[] numbers = GenerateRandomNumbers(arrayLength);

// Выводим массив на экран
Console.WriteLine("Сгенерированный массив случайных трехзначных чисел:");
PrintArray(numbers);

// Подсчитываем количество четных чисел в массиве
int evenCount = CountEvenNumbers(numbers);

// Выводим результат на экран
Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
    

    // Функция для генерации случайных трехзначных чисел и заполнения ими массива
    static int[] GenerateRandomNumbers(int length)
{
    Random rand = new Random();
    int[] randomNumbers = new int[length];

    for (int i = 0; i < length; i++)
    {
        randomNumbers[i] = rand.Next(100, 1000); // генерируем трехзначные числа от 100 до 999
    }

    return randomNumbers;
}

// Функция для печати массива
static void PrintArray(int[] arr)
{
    foreach (var num in arr)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}

// Функция для подсчета количества четных чисел в массиве
static int CountEvenNumbers(int[] arr)
{
    int evenCount = 0;

    foreach (var num in arr)
    {
        if (num % 2 == 0)
        {
            evenCount++;
        }
    }

    return evenCount;
}

Задача 3: Напишите программу, которая перевернёт одномерный массив 
(первый элемент станет последним, второй – предпоследним и т.д.)*/

// Создаем исходный массив
int[] array = { 1, 2, 3, 4, 5 };

// Выводим исходный массив на экран
Console.WriteLine("Исходный массив:");
PrintArray(array);

// Переворачиваем массив
ReverseArray(array);

// Выводим перевернутый массив на экран
Console.WriteLine("\nПеревернутый массив:");
PrintArray(array);
    

    // Функция для переворачивания массива
    static void ReverseArray(int[] arr)
{
    int left = 0;
    int right = arr.Length - 1;

    while (left < right)
    {
        // Обмен значений между левым и правым элементами массива
        int temp = arr[left];
        arr[left] = arr[right];
        arr[right] = temp;

        // Сдвигаем указатели
        left++;
        right--;
    }
}

// Функция для печати массива
static void PrintArray(int[] arr)
{
    foreach (var num in arr)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}


