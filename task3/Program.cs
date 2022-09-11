
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[rows, columns];

FillMatrix(matrix);
Console.Write("[{0}]",string.Join(" ; ",FindAvg(matrix)));

void FillMatrix(double[,] array)
{
    Random rnd = new Random();// создается объект класса Рандом
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rnd.Next(0, 101) + rnd.NextDouble(), 1);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
double[] FindAvg(double[,] matr)
{
    double[] arrayWithAvgValues = new double[matr.GetLength(1)];
    double sum = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i, j];
        }
        arrayWithAvgValues[j]=Math.Round(sum/matr.GetLength(0),2);
    }
    return arrayWithAvgValues;
}
