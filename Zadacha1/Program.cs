// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int day = new Random().Next(1,8);
Console.WriteLine(day);
if (day > 0 && day <= 5)
{
    Console.WriteLine("День не выходной");
}
else
{
    Console.WriteLine("День выходной");
}