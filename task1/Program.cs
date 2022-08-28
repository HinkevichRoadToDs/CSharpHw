Console.Write("Введите число: ");
string number = Console.ReadLine();


if( number.Length != 5)
{
    Console.WriteLine("Нужно ввести пятизначное число");
}
else if (number[0] == number[4] && number[1]== number[3])
{
    Console.WriteLine("Это палиндром");
}
else
{
    Console.WriteLine("Это не палиндром");
}

