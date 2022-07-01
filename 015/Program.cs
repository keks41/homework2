string[] day = {"Понедельник", "вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение"};
Console.WriteLine("enter number (1-7)") ;
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number < 8)
{
    Console.Write("Сегодня "+ day[number-1]);
    if (number == 6 || number == 7) {
        Console.Write("Выходной");
    }


}



