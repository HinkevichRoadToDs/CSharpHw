Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[rows, columns];

Random rnd = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        // Math.Round округляет десятичные числа до определенного знака
        matrix[i, j] = Math.Round(rnd.Next(0, 10000001) + rnd.NextDouble(), 5);
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}