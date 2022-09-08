
Console.Write("Сколько чисел вы хотите ввести? ");
int numb = Convert.ToInt32(Console.ReadLine());
int[] array = new int [numb];

int PositiveCount(int count)
{
    int countOfPositive = 0;
    for(int i = 0; i < count;i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0)
        {
            countOfPositive+=1;
        }
        Console.WriteLine("[{0}]",string.Join(",", array));
    }
    return countOfPositive;
}
int posCount = PositiveCount(numb);
Console.Write($"количество положительных чисел = {posCount}");
