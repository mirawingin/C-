// Задача 1: 
// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.




/* Задаем двумерный массив символов
char[,] charArray = { { 'H', 'e', 'l', 'l', 'o' },
                               { 'W', 'o', 'r', 'l', 'd' } };

// Создаем строку из символов массива
string str = CharArrayToString(charArray);

// Выводим строку на консоль
Console.WriteLine(str);


// Метод для создания строки из двумерного массива символов
string CharArrayToString(char[,] charArray)
{
    string result = " ";

    // Получаем количество строк и столбцов в массиве
    int rows = charArray.GetLength(0);
    int cols = charArray.GetLength(1);

    // Обходим каждый элемент массива и добавляем его к строке
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            result += charArray[i, j];
        }
    }

    // Возвращаем полученную строку
    return result;
}*/

// Задача 2:
// Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.


// Задаем строку, содержащую латинские буквы в обоих регистрах
/*string inputString = "CaPiTal SleEpS";

// Формируем строку, в которой все заглавные буквы заменены на строчные
string lowercaseString = ConvertToLowerCase(inputString);

// Выводим строку на консоль
Console.WriteLine(lowercaseString);


// Метод для замены всех заглавных букв на строчные в строке
string ConvertToLowerCase(string input)
{
    string result = "";

    // Обходим каждый символ в строке
    foreach (char c in input)
    {
        // Проверяем, является ли символ заглавной буквой
        if (char.IsUpper(c))
        {
            // Если да, добавляем символ в нижнем регистре к результирующей строке
            result += char.ToLower(c);
        }
        else
        {
            // Иначе добавляем символ без изменений
            result += c;
        }
    }

    // Возвращаем полученную строку
    return result;
}*/


// Задача 3:
// Задайте произвольную строку. Выясните, является ли она палиндромом.


// Задаем произвольную строку
/*string inputString = "Was it a car or a cat I saw"; //Я увидел машину или кота

// Проверяем, является ли строка палиндромом
bool isPalindrome = IsPalindrome(inputString);

// Выводим результат на консоль
if (isPalindrome)
{
    Console.WriteLine("Строка является палиндромом.");
}
else
{
    Console.WriteLine("Строка не является палиндромом.");
}
    

    // Метод для проверки строки на палиндром
    static bool IsPalindrome(string str)
{
    // Приводим строку к нижнему регистру для удобства сравнения
    str = str.ToLower();

    // Устанавливаем индексы для начала и конца строки
    int left = 0;
    int right = str.Length - 1;

    // Пока не достигнут конец или начало строки
    while (left < right)
    {
        // Пропускаем пробелы и знаки препинания
        if (!char.IsLetter(str[left]))
        {
            left++;
            continue;
        }
        if (!char.IsLetter(str[right]))
        {
            right--;
            continue;
        }

        // Если символы на текущих индексах не совпадают, строка не является палиндромом
        if (str[left] != str[right])
        {
            return false;
        }

        // Переходим к следующему символу с начала и конца строки
        left++;
        right--;
    }

    // Если проверка успешно завершена, строка является палиндромом
    return true;
}

// Задача 4*
// (не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

// Исходная строка
string inputString = "Задайте строку, состоящую из слов, разделенных пробелами.";

// Получаем перевернутую строку
string reversedString = ReverseWords(inputString);

// Выводим результат на консоль
Console.WriteLine(reversedString);


// Метод для переворачивания слов в строке
static string ReverseWords(string str)
{
    // Разбиваем строку на массив слов, используя пробел в качестве разделителя
    string[] words = str.Split(' ');

    // Создаем новую строку для хранения результата
    string reversedString = "";

    // Обходим массив слов в обратном порядке
    for (int i = words.Length - 1; i >= 0; i--)
    {
        // Добавляем слово к результирующей строке
        reversedString += words[i];

        // Добавляем пробел после слова, если это не последнее слово
        if (i > 0)
        {
            reversedString += " ";
        }
    }

    // Возвращаем перевернутую строку
    return reversedString;
}*/
