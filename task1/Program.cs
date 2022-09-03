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

int EvenNumbers(int[] collection, int length)
{
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (collection[i] % 2 == 0)
        {
            count++;
        }

    }
    return count;
}
int evenNumbersCount = EvenNumbers(array, size);
Console.WriteLine("Количество четных чисел равно = " + evenNumbersCount);