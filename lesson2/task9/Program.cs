
int[] n = array.Length - 1;

int[] result = new int[array.Length / 2];

for (int i = 0; i < n - i; i++)
{
    result[i] = array[i] * array[n - i];
}
for (int i = 0; i < result.Length; i++)
{
    System.Console.Write(result[i] + " ");
}
