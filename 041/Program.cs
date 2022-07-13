
    Console.WriteLine("Введите размерность массива :");
    int len = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[len];
    int count = 0;
    
        for (int i = 0; i < arr.Length; i++ )
        {
            Console.WriteLine($"Введите значение для элемента [{i}] "); 
            arr[i] = Convert.ToInt32(Console.ReadLine());
            if (arr[i] > 0) count++;

        } 
    
     Console.WriteLine(count);
