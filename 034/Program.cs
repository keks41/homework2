// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2
int lenght = 9;
int [] newArr = new int [lenght];
int result = 0;
for(int i = 0; i<newArr.Length; i++){
    newArr[i]= new Random().Next(100,1000);
    Console.Write(newArr[i] + " ");
    Console.WriteLine();
    if (newArr[i]%2 ==0)
    {
        result = result+1;
    }
    
    
}
Console.WriteLine($"В массиве четный цифр   :"  + result);



