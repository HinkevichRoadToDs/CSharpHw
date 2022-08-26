Console.WriteLine("Введите номер дня ");
int numberDaY = Convert.ToInt32(Console.ReadLine());

string[] array = {"Пн","Вт","Ср","Чт","Пт","Сб","Вск"};
int size = array.Length;

Console.Write(array[numberDaY-1]);

if (numberDaY == 6 ||numberDaY == 7) Console.Write(", выходной день");
