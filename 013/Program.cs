void  ThirdNumber(int x) {
    int div = 1;
    while (x / div > 10) {
        div *= 10;
    }
    if (div < 100) {
        Console.WriteLine("Маленькое число");

    }else {
        int digit = (x / (div/100))% 10;
        Console.WriteLine("3 число {0}", digit);
    }
}
ThirdNumber(14657);
