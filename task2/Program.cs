// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите k1 ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1 ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k2 ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2 ");
double b2 = Convert.ToDouble(Console.ReadLine());

double CrossPointX(double K1,double B1,double K2,double B2)
{
    double x = (B2-B1)/(K1-K2);// приравнял k1*x+b1=k2*x+b2 и вывел х
    return x;
}
double cross_point_x = CrossPointX(k1,b1,k2,b2);

double CrossPointY(double K_1,double B_1,double pointX)
{
    double y = K_1 * pointX + B_1;
    return y;
}
double cross_point_y = CrossPointY(k1,b1,cross_point_x);
if (k1 == k2) 
{
    Console.WriteLine("Графики линейных функций параллельны");
}
else if(b1 == b2)
{
    Console.WriteLine($"Точка пересечения (0,{b1})");
}
else
{
    Console.WriteLine($"Точка пересечения ({cross_point_x},{cross_point_y})");
}
