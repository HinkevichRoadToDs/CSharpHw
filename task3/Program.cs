Console.Write("Введите количество строк матрицы А: ");
int rows0 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы А: ");
int columns0 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк матрицы В: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы В: ");
int columns1 = Convert.ToInt32(Console.ReadLine());

double[,] matrixA = new double[rows0, columns0];
                    // {{2,3,3},
                    //  {5,4,3},
                    //  {7,3,2},
                    //  {3,33,3}};// матрица А
double[,] matrixB = new double[rows1, columns1];
                    // {{2,3,3,5},
                    //  {5,4,3,9},
                    //  {7,3,2,12}}; матрица В
Console.WriteLine("Матрица А");
FillAndPrintMatrix(matrixA);//PrintMatrix(matrixA);
Console.WriteLine("Матрица В");
FillAndPrintMatrix(matrixB);//PrintMatrix(matrixB);

double[,] matrixProduct = new double[matrixA.GetLength(0), matrixB.GetLength(1)];
if (matrixA.GetLength(1) == matrixB.GetLength(0))
{
matrixProduct = MatrixProduct(matrixA, matrixB);
Console.WriteLine("Произведение матриц АхВ");
PrintMatrix(matrixProduct);
}
else
{
    Console.WriteLine("Число столбцов в А не совпадает с числом строк в В");
}

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
// Произведение двух матриц АВ имеет смысл только в том случае,
// когда число столбцов матрицы А совпадает с числом строк матрицы В.
// В произведении матриц АВ число строк равно числу строк матрицы А , 
// а число столбцов равно числу столбцов матрицы В.
double[,] MatrixProduct(double[,] A, double[,] B)
{
    double[,] AB = new double[A.GetLength(0), B.GetLength(1)];
    double sum = 0;
    double productIJ = 0;
    int k = 0;
    int j = 0;
    for (int i = 0; i < A.GetLength(0); i++)
    {
        j = 0;
        while (j < B.GetLength(1))
        {
            sum = 0;
            k = 0;
                while (k < A.GetLength(1))
                {
                    productIJ = A[i, k] * B[k, j];
                    sum += productIJ;
                    k++;
                }
                AB[i, j] = Math.Round(sum,1);
                j++;
        }
    }
    return AB;
}