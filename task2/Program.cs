double[,] matrix = new double[10,10]; 

FillMatrix(matrix);

Console.Write("Введите нужный элемент: ");
double necessaryNumber = Convert.ToDouble(Console.ReadLine());
necessaryNumber = Math.Round(necessaryNumber,1);// округляю до одного знака после запятой

void FillMatrix (double[,] array)
{
    Random rnd = new Random();// создается объект класса Рандом
    for (int i = 0; i < array.GetLength(0);i++)
    {
        for (int j = 0; j < array.GetLength(1);j++)
        {
            array[i,j]= Math.Round(rnd.Next(0,101) + rnd.NextDouble(),1);
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
int FindNecessaryElement(double[,] matr,double n)
{
    int count = 0;
    for (int i = 0; i < matr.GetLength(0);i++)
    {
        for (int j = 0; j < matr.GetLength(1);j++)
        {
            if(n == matr[i,j]) count++;
        }
    }
    return count;
}
int count = FindNecessaryElement(matrix,necessaryNumber);
if (count>0){
  Console.Write($"Число есть в массиве в количестве {count}"); 
}
else 
{
    Console.Write("Такого числа в массиве нет");
}


