Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
///minRandom, maxRandom
int[,] GetArray(int m, int n, int minRandom, int maxRandom)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minRandom, maxRandom + 1);

        }
        return result;
    }
}
int[,] array = GetArray(rows, columns, 0, 10);

//Задача 53: Задайте двумерный массив.
// Напишите программу, которая поменяет
// местами первую и последнюю строку массива.



/// m на n, m - кол-во строк
/// n - кол-во столбцов
/// minRandom, maxRandom
// Задача 53: Задайте двумерный массив.
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

void ChangeRows(int[,] matrix)
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

Console.WriteLine("Введите количество строк :");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов :");
int columns = int.Parse(Console.ReadLine());

int [,] GetArray(int m, int n, int minRandom, int maxRandom)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minRandom, maxRandom + 1);
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
            Console.Write(inputArray[i, j] + "\t");
        }
    Console.WriteLine();    
    }
    
}
PrintArray(array);

void changeRows(int[,] matrix)
{
    int numberLastRows = matrix.GetLength(0) - 1;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[numberLastRows, i];
        matrix[numberLastRows,i] = temp;
    }
}
changeRows(array);
System.Console.WriteLine(" Результат");
PrintArray(array);

int [] array= {1,2,3,4,5,};
System.Console.WriteLine($"[{string.Join("; ", array)}]");

int rows = 3;
int columns = 3;
int minValue = int.MaxValue;
int[,] array = new int[rows, columns];
int indexRows = 0;
int indexColumns = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(11);
        System.Console.Write(array[i, j] + "\t");
        if (minValue > array[i, j])
        {
            minValue = array[i, j];
            indexRows = i;
            indexColumns = j;
        }
    }
    System.Console.WriteLine();
}
System.Console.WriteLine("минимум :" + minValue);
for (int i = 0; i < rows; i++)
{
    if (i != indexRows)
    {
        for (int j = 0; j < columns; j++) 
        {
            if (j != indexColumns)
            {
                System.Console.Write(array[i, j] + "\t");
            }
        }
        System.Console.WriteLine();
    }
    
}
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

void sortRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
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
                Console.WriteLine();
            }
        }
    }
}
sortRows(array);
System.Console.WriteLine(" Результат");
PrintArray(array);