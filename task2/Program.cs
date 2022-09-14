Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[rows, columns];
FillAndPrintMatrix(matrix);

void FillAndPrintMatrix(double[,] array)
{
    Random rnd = new Random();
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
double[] ReturnRowsSum(double[,] matr)
{
    double[] rowsSumArray = new double[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            rowsSumArray[i] += matr[i, j];
            rowsSumArray[i] = Math.Round(rowsSumArray[i], 1);
        }
    }
    return rowsSumArray;
}
double[] sumOfRows = new double[ReturnRowsSum(matrix).Length];
sumOfRows = ReturnRowsSum(matrix);
Console.WriteLine();
Console.WriteLine("[{0}]", string.Join(" ; ", sumOfRows));
int rowIndexOfMin = 0;
double min = sumOfRows[0];
for (int i = 1; i < sumOfRows.Length; i++)
{
    if (sumOfRows[rowIndexOfMin] > sumOfRows[i])
    {
        rowIndexOfMin = i;
    }
}
Console.Write($"Строка с наименьшей суммой элементов имеет индекс {rowIndexOfMin}");