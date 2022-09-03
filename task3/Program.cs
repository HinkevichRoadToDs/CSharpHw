Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = new double[size];

void FillArray(double[] arr, int len)
{
    for (int i = 0; i < len; i++)
    {
        double n1 = new Random().Next(-100000, 100000);
        double n2 = new Random().Next(-100000, 100000);
        arr[i] = n1 / n2;
    }
}
FillArray(array, size);
Console.WriteLine("[{0}]", string.Join(";", array));

double MaxMinDifference(double[] collection,int length)
{
    double min = collection[0];
    double max = collection[0];    
    for (int i =0; i <length;i++)
    {
        if (collection[i]> min)
        {
            if (collection[i]>max) max = collection[i];
        }
        else if (collection[i]<min)
        {
            min = collection[i];
        }
    }
    double difference = max - min;
    return difference;
}
Console.WriteLine($"Разница между максимальным и минимальным = {MaxMinDifference(array,size)}");
