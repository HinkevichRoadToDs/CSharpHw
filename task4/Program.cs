Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z: ");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] cube = new int[x, y, z];

FillAndPrintMatrix(cube);
void FillAndPrintMatrix(int[,,] threedArray)
{
    Random rnd = new Random();
    for (int i = 0; i < threedArray.GetLength(0); i++)
    {
        for (int j = 0; j < threedArray.GetLength(1); j++)
        {
            for (int k = 0; k < threedArray.GetLength(2); k++)
            {
                threedArray[i, k, j] = rnd.Next(10, 100);
                Console.Write(threedArray[i, j, k] + "(" + i + j + k + ")" + "\t");
            }
            Console.WriteLine();
        }  
    }
}
