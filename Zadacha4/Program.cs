// Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("Введите координаты точки 1 по оси X: ");
int x1 = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите координаты точки 1 по оси Y: ");
int y1 = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите координаты точки 1 по оси Z (для 2D вводить 0): ");
int z1 = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите координаты точки 2 по оси X: ");
int x2 = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите координаты точки 2 по оси Y: ");
int y2 = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите координаты точки 2 по оси Z (для 2D вводить 0): ");
int z2 = int.Parse(Console.ReadLine()?? "0");
double distance = Math.Sqrt(Math.Abs(x1 - x2) * Math.Abs(x1 - x2) + Math.Abs(y1 - y2) * Math.Abs(y1 - y2) + Math.Abs(z1 - z2) * Math.Abs(z1 - z2));
Console.WriteLine($"Расстояние между точками равно {distance}");