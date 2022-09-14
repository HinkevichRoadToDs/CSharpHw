int[,] matrix = new int[4, 4];

void Spiral(int i, int j, int summand)
{
    {
        if (matrix[i, j] == 0)
        {
            matrix[i, j] += summand;
            summand++;
            if (j + 1 < matrix.GetLength(1))
            {
                Spiral(i, j + 1, summand);
            }
            if (i + 1 < matrix.GetLength(0))
            {
                Spiral(i + 1, j, summand);
            }
            if (j - 1 >= 0)
            {
                Spiral(i, j - 1, summand);
            }
            if (i - 1 >= 0)
            {
                Spiral(i - 1, j, summand);
            }
        }
    }
}
void PrintMatrix(int[,] array)
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
void PrintAsString(int[,] arr)
{
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] < 10)
                {
                    Console.Write("0" + arr[i, j] + "\t");
                }
                else
                {
                    Console.Write(arr[i, j] + "\t");
                }
            }
            Console.WriteLine();
        }
    }
}
Spiral(0, 0, 1);
PrintMatrix(matrix);
Console.WriteLine();
PrintAsString(matrix);