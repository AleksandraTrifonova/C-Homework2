// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти от 1 до 4;");
int a = int.Parse(Console.ReadLine()?? "0s");

if (a == 1)
{
    Console.WriteLine("Диапазон возможных координат: x > 0, y > 0");
}
if (a == 2)
{
    Console.WriteLine("Диапазон возможных координат: x < 0, y > 0");
}
if (a == 3)
{
    Console.WriteLine( "Диапазон возможных координат: x < 0, y < 0");
}
if (a == 4)
{
    Console.WriteLine( "Диапазон возможных координат: x > 0, y < 0");
}
