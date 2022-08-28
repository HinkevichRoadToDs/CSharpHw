Console.WriteLine("Введите N: ");
int number = Convert.ToInt32(Console.ReadLine());


for (int count = 1; count <= number; count++)
{
    Console.Write(Math.Pow(count,3) + " ");
}