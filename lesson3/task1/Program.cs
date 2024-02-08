// код считает и выводит квадрат числа (n)
/*int n = 6;

int i = 1;
while (i <= n)
{
    System.Console.Write($"{i * i} ");
    i = i + 1;
}

Функция  вычесляет значение формулы (a*b)/(c+d);
                                       
double CalculateFormula(int a, int b, int c, int d)
{
    double numerator = a * b;
    int denominator = c + d;
    double result = numerator / denominator;
    return result;
}
double result = CalculateFormula(154, 45, 37, 54);
System.Console.WriteLine(result);*/
/*функция вывода квадрата

void PrintSquares(int limit)
{
    int i = 1;
    while (i <= limit)
    {
        System.Console.Write($"{i * i} ");
        i++;
    }
}

PrintSquares(5);
PrintSquares(10);
PrintSquares(15);

функция которая обнуляет четные элементы массива

void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
      if (arr[i] % 2 == 0)
      {
        arr[i] = 0;
      }
    }
}
void PrintArray (int[] arr)
{
    foreach (int e in arr)
    {
      System.Console.Write($"{e} ");  
    }
    
}
int[] array = {8, 65, 20, 24, 41};
ZeroEvenElements(array);
PrintArray(array);

функция генерация случайных чисел

Random rnd = new Random();
int size = 10; // количество случайных чисел
int[] arr_int = new int[size];
int i = 0;
while (i < size)
{
    arr_int[i] = rnd.Next(50, 87);  //диапазон случайных чисел
    i++;
}
i = 0;
while (i < size)
{
   System.Console.Write($"{arr_int[i]} ");
   i++; 
}


//Ввод значений с консоли
int size = 3; // количество случайных чисел
int[] arr_int = new int[size];
int i = 0;
while (i < size)
{
    System.Console.WriteLine("Ввидите элемент массива(целое число):");
    string input = Console.ReadLine();
    arr_int[i] = Convert.ToInt32(input);
    i++;
}