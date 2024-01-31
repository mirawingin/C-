int n = 10;
int[] array = { 3, 12, 9, 4, 45, 56, 31, 10, 2, 48 };
int i = 0;

while (i < n)
{
    if (array[i] % 2 == 0)
    {
        System.Console.Write($"{array[i]} ");
    }
    i = i + 1;
}