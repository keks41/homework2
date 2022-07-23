/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1)
*/
Console.Clear();
System.Console.WriteLine("Введите x ");
int x = int.Parse(Console.ReadLine());
System.Console.WriteLine(" Введите y :");
int y = int.Parse(Console.ReadLine());
System.Console.WriteLine(" Введите z :");
int z = int.Parse(Console.ReadLine());
int[,,] array = GetArray(x, y, z);
int[,,] GetArray(int x,int y, int z)
{
    int[,,] array = new int[ x,  y,  z];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return array;
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k}) " );
            }
            Console.WriteLine();
        }
        
    }
     

}

PrintArray(array);
/*
Console.Clear();
Console.WriteLine("Введите кол-во строк и столбцов массива: "); int arrowSize = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента: "); int maxNumb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значчение элемента: "); int minNumb = int.Parse(Console.ReadLine());
Console.WriteLine("Массив со случайными значениями: ");

int[,,] array = GetArray(arrowSize, maxNumb, minNumb);
int[,,] GetArray(int arrowSize, int maxNumb, int minNumb)
{
    int[,,] array = new int[arrowSize, arrowSize,arrowSize];
    for (int i = 0; i < arrowSize; i++)
    {
        for (int j = 0; j < arrowSize; j++)
        {
            for (int n = 0; n < arrowSize; n++)
            {
                array[i,j,n] = new Random().Next(minNumb, maxNumb+1);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(2); n++)
            {
                Console.Write($"{array[i,j,n]}({i},{j},{n}) " );
            }
            Console.WriteLine();
        }
        
    }
     

}

PrintArray(array);
*/