Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

void FillArray(int[] arr, int len)
{
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}
FillArray(array, size);
Console.WriteLine("[{0}]", string.Join(",", array));

int SumNotEvenNumbers(int[] collection, int length)
{
    int sum = collection[1];
    for (int i = 3; i < length; i+=2)
    {
        sum += collection[i];
    }
    return sum;
}
int summa = SumNotEvenNumbers(array, size);
Console.WriteLine($"Сумма элементов на нечетных позициях = {summa}");