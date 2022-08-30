int[] arr = {2,1,5,3,1,4,9,6,7,8,2};
ArraySort(arr);
PrintArray(arr);
void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void ArraySort(int[] collection)
{
    int i =0;
    int j = 0;
    int size = collection.Length; 
    while ( i < size)
    {
        j= i + 1;
        int min = i;
        while(j < size)
        {
            if(collection[min] > collection[j])
            {
                min = j;
            }
            j++;
        }
        int temporary = collection[i];
        collection[i] = collection[min];
        collection[min]= temporary;
        i++;
    }
}