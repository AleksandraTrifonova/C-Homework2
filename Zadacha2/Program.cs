// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите число 1:");
int a1 = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите число 2:");
int a2 = int.Parse(Console.ReadLine()?? "0");
if (a1 * a1 == a2 || a2 * a2 == a1)
{
    Console.WriteLine("Одно из чисел является квадратом другого");
}
else
{
    Console.WriteLine("Ниодно из чисел не является квадратом другого");
}
