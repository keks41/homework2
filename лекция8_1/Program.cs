/*Console.WriteLine("Введите количество строк :");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов :");
int columns = int.Parse(Console.ReadLine());
int MaxValue = int.MinValue;

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(11);
        }

    }
    return result;

}
int[,] array = GetArray(rows, columns);
void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }

}
PrintArray(array);

void sortRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) ; j++)

        {
            for (int k = 0; k < matrix.GetLength(1)-1; k++)
            {   
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
                
            }
        }
    }
    Console.WriteLine();
}
sortRows(array);
System.Console.WriteLine(" Результат");
PrintArray(array);
*/
Console.WriteLine("Введите количество строк :");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов :");
int columns = int.Parse(Console.ReadLine());
int MaxValue = int.MinValue;

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(11);
        }

    }
    return result;

}
int[,] array = GetArray(rows, columns);
void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }

}
PrintArray(array);

int minSumRow(int [,] array);
int minSum = 0;
int sum = 0;
int numberMinSum = 0;

for (int i = 0; i < array.GetLength; i++)
{
    for (int j = 0; j < array.GetLength; j++)
    {
        sum += array[i,j];
        
    }
}
minSumRow(array);
System.Console.WriteLine(" Результат");
PrintArray(array);