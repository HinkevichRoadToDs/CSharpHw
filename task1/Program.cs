Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number1 == number2) 
{
Console.WriteLine("Числа равны");
}
else
{
    if (number1 > number2)
    {
        Console.WriteLine("max = " + max);
    }
    else
    {
        max=number2;
        Console.WriteLine("max = " + max);
    }
}