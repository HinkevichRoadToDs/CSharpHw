Console.Write("Введите число A: ");
double numberA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{numberA} ^ {numberB} = {RaiseTheNumber(numberA,numberB)}");

double RaiseTheNumber(double A, int B)
{
    double result = Math.Pow(A,Convert.ToDouble(B));
    return result;
}





