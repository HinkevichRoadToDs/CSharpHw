Console.Write("Введите  число: ");
int number = Convert.ToInt32(Console.ReadLine());
string StringNumber = Convert.ToString(number);

int SumOfDigits(string num)
{
    int size = num.Length;
    int sum = num[0]- '0'; // конвертация char в int xD
    for (int i = 1; i < size; i++) 
    {
        sum += (num[i]-'0');
    }
    return sum;
}
Console.WriteLine($"Cумма цифр в числе = {SumOfDigits(StringNumber)}");
