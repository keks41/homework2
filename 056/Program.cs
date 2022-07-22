// Напишите программу, которая поменяет
// местами первую и последнюю строку массива.

/*Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()); // аналог ConvertToInt32
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

/// m на n, m - кол-во строк
/// n - кол-во столбцов
/// minRandom, maxRandom
int[,] GetArray(int m, int n, int minRandom, int maxRandom)
{
    // Табличка - матрица (m на n)
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++) // цикл по строчкам
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minRandom, maxRandom + 1); // [);
        }

    }
    return result;
}

int[,] array = GetArray(rows, columns, 0, 10);

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t"); //inputArray[i,j] + " "
                                                    // 1 2 3 4
                                                    // 5 3 2 1
        }
        Console.Write("\n");
    }
}
PrintArray(array);

/*void ChangeRows(int[,] matrix)
{
int numberLastRow = matrix.GetLength(0) - 1;
for (int i = 0; i < matrix.GetLength(1); i++)
{
int temp = matrix[0,i];
matrix[0, i] = matrix[numberLastRow,i];
matrix[numberLastRow,i] = temp;
}
}
ChangeRows(array);
Console.WriteLine("Результат: ");
PrintArray(array);
*/
System.Console.WriteLine("Введите количество строк массива :");
int rows = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов массива :");
int columns = int.Parse(Console.ReadLine());
int[,] GetArray(int m, int n, int minRandom, int maxRandom)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minRandom, maxRandom);
        }
    }
    return result;
}
int[,] array = GetArray(rows, columns, 0, 11);

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.Write("\n");
    }

}
PrintArray(array);

int SumRow(int[,] array)
{
    int[] arrSum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrSum[i] += array[i, j];
        }
        Console.WriteLine($"Сумма элементов строк: {arrSum[i]}");
    }

    int minSum = arrSum[0];
    int position = 0;
    for (int i = 0; i < arrSum.Length; i++)
    {
        if (arrSum[i] < minSum)
        {
            position = i;
            minSum = arrSum[i];
        }
    }
    return position + 1;
}
int[] arrSum = new int[4];

int result = SumRow(array);
System.Console.WriteLine($"Строкас наименьшей суммой элементов {result} ");
