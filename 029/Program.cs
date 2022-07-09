int[] array = new int[8];
Random rnd = new Random();

void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0-10, 10);
        Console.Write($"{array[i]} , ");
    }
}
PrintArr(array);
