//ДВУМЕРНЫЕ МАССИВЫ
/*интерполяция данных
int[,] matrix = new int[3, 5];

Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        matrix[i, j] = rnd.Next(1, 14);
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        System.Console.Write($"{matrix[i, j]} ");
    }
System.Console.WriteLine();
    
}

Функция для создания и вывода двумерного массива

int[,] CreateMatrix(int rowCount, int columCount)
{
    int[,] matrix = new int[rowCount, columCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}
void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }

}
int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);

Способы создания двумерного масссива
1)способ:
int[,] table1 = new int[2, 4]{
{1, 4, 5, 8},
{6, 7, 5, 2}
};

2) способ:
int[,] table2 = new int[, ]{
{1, 4, 5, 8},
{6, 7, 5, 2}
};

3) способ:
int[,] table3 = {
{1, 4, 5, 8},
{6, 7, 5, 2}
};

задача создать и заполнить двумерный массив рандомными числами
вывести на экран только чётные числа из этого массива

int[,] CreateMatrix(int rowCount, int columCount)
{
    int[,] matrix = new int[rowCount, columCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}
void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(3, 4);
ShowMatrix(matrix);
foreach (int e in matrix)
{
    if (isInteresting(e) == true)
    {
        System.Console.WriteLine(e);
    }
}

bool isInteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if (sumOfDigits % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
int GetSumOfDigits(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum = sum % 10;
        value = value / 10;
    }
    return sum;
}

Работа со стракой, ввод через клавиатуру. сортировка от чисел и спец знаков 
ывод букв по порядку

string GetLetters(string s)
{
    string letters = " ";
    foreach(char e in s)
    {
        if ( char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
     }
     return letters;
}

string str = Console.ReadLine();
string result = GetLetters(str);
System.Console.WriteLine(result);

