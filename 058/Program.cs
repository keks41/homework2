Console.Clear();
System.Console.WriteLine("Введите количество строк и столбцов массива :");
int size = int.Parse(Console.ReadLine());
System.Console.WriteLine("Ведите максимальное значение :");
int MaxValue = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите минимальное значение :");
int MinValue = int.Parse(Console.ReadLine());

int[,] array = GetArray(size, MinValue, MaxValue);
int[,] GetArray(int size, int MinValue, int MaxValue)
{
    int[,] array = new int[size, size];
    for (int i = 0; i < size; i++)

    {
        for (int j = 0; j < size; j++)
        {
            array[i, j] = new Random().Next(MinValue, MaxValue);
            
        }

    }
    return array;
}
System.Console.WriteLine(" Первый массив");
PrintArray(array);
int[,] arraytwo = GetArray(size, MinValue, MaxValue);
int[,] GetArraytwo(int size, int MinValue, int MaxValue)
{
    int[,] arraytwo = new int[size, size];
    for (int i = 0; i < arraytwo.GetLength(0); i++)

    {
        for (int j = 0; j < arraytwo.GetLength(1); j++)
        {
            arraytwo[i, j] = new Random().Next(MinValue, MaxValue);
        }
        System.Console.WriteLine();
    }
    return arraytwo;
}
System.Console.WriteLine("Второй массив");
PrintArraytwo(arraytwo);
void PrintArray(int[,] array)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine("\n");
    }
    
}
void PrintArraytwo(int[,] arraytwo)
{
    for (int i = 0; i < arraytwo.GetLength(0); i++)
    {
        for (int j = 0; j < arraytwo.GetLength(1); j++)
        {
            System.Console.Write(arraytwo[i, j] + "\t");
        }
        Console.WriteLine("\n");
    }
    
}
void SumArrayArrayTwo(int[,] array, int[,] arraytwo)
{
    int[,] result = new int[array.GetLength(0), arraytwo.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < arraytwo.GetLength(1); j++)
        {
            result[i, j] = array[i, j] * arraytwo[i, j];
            System.Console.Write(result[i, j] + "\t");
        }
        System.Console.WriteLine("\n");
    }

}
System.Console.WriteLine(" Полученный результат перемножения :");
SumArrayArrayTwo(array, arraytwo);
