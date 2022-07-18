//Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
//двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.


Console.WriteLine("Введите M  :");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N  :");
int N = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите i0  :");
int i0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите j0  :");
int j0 = Convert.ToInt32(Console.ReadLine());
int [,] arr = new int[M, N];
Random rnd = new Random();
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++ )
    {
        arr[i, j] = rnd.Next(0, 10);
        Console.Write(arr[i, j] + "\t ");
         
        
    }
    Console.WriteLine();
}
if (i0 >= M || j0 >= N || i0 < 0 || j0 < 0){
    Console.WriteLine(" Такого элемента нет ");

}
else {
    Console.WriteLine("Элемент с индексом i0 = i и j0 = j  {0}" , arr [i0 , j0]);
}




