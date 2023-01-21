// Определить номер четверти плоскости, в которой находится 
//точка с координатами X и Y, причем X не равен 0, Y не равен 0.
Console.WriteLine("Введите координаты точки X и Y отличные от нуля");
Console.WriteLine("X = ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Y = ");
int y = int.Parse(Console.ReadLine()!);
if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в первой четверти ");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находится во второй четверти ");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третей четверти ");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в четвертой четверти ");
}
else
{
    //Console.WriteLine("Был введен ноль! Запустите программу заново.");
}