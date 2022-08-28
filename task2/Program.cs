Console.WriteLine("Введите координаты точки А(x,y,z): ");
double xa = Convert.ToDouble(Console.ReadLine());
double ya = Convert.ToDouble(Console.ReadLine());
double za = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B(x,y,z): ");
double xb = Convert.ToDouble(Console.ReadLine());
double yb = Convert.ToDouble(Console.ReadLine());
double zb = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt( Math.Pow(xb-xa,2) + Math.Pow(yb-ya,2) + Math.Pow(zb-za,2) );

Console.WriteLine($"Расстояние равно {distance}");
