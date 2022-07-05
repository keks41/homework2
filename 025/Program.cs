Console.WriteLine("Введите число 1 ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2 ");
int B = Convert.ToInt32(Console.ReadLine());
int result = 1;
for(int i = 1; i <= B; i++)
{
     result = result * A; 
}
Console.Write($" Число {A} в степени {B} = {result}"); 
