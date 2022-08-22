Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int StartNumber = 2;

while (StartNumber <= number)
{
    Console.Write(StartNumber + " ");
    StartNumber=StartNumber+2;
}