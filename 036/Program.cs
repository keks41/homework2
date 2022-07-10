//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
int[] array = new int [8];



int sum = 0;
for(int i = 0; i<array.Length; i++)

{
    array[i]= new Random().Next(1,200);
    Console.Write(array[i] + " ");
    if (array[i] %2 != 0 )
    {
        sum = sum + array[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма нечетных элементов массива :" +  sum);