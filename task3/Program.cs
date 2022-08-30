Console.Write("Введите размер массива, который вы хотите получить: ");
int ArraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[ArraySize];

GenerateAndPrintArray(array,ArraySize);

void GenerateAndPrintArray(int[]arr,int size)
{
    
    for  (int i = 0; i < size; i++) 
    {
        arr[i] = new Random().Next(0,2147483647);
        Console.Write(arr[i] + " ");
    }
      
}
