int n = 5;
int[] array = { 20, 3, 25, 8, 13 };
int i = 0;
int max = array[0];
while (i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}

System.Console.WriteLine(max);
