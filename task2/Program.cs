    int number = Convert.ToInt32(Console.ReadLine());
    
    int numb1 = number % 10;
     if( number <= 99 || number >= 1000)
     {
        Console.WriteLine("Это не трехзначное число");
     }
     else
     {
        Console.WriteLine(numb1);
     }