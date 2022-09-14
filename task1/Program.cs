Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[rows, columns];

void FillMatrix(double[,] array)
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
void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void SortMinMax(double[,] arr)
{
    int maxPositionI = 0;
    int maxPositionJ = 0;
    double temporary = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            maxPositionI = i;
            maxPositionJ = j;
            temporary = 0;
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[maxPositionI, maxPositionJ] < arr[i, k])
                {
                    temporary = arr[i, k];
                    arr[i, k] = arr[maxPositionI, maxPositionJ];
                    arr[maxPositionI, maxPositionJ] = temporary;
                }
            }
        }
    } 
}
FillMatrix(matrix);
SortMinMax(matrix);
Console.WriteLine();
PrintMatrix(matrix);

