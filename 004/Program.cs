// Программа проверяет пятизначное число на палиндром. Пример: 12321
Console.Clear();
//int number = new Random().Next(10000,99999); Замучаешься повторять программу)
Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine()); // Проще ввести вручную!
//Console.WriteLine("Дано число " + number);
int a = number % 10;
int b = number % 100 / 10;
//int с = number % 1000 / 100;
int d = number % 10000 / 1000;
int e = number % 100000 / 10000;
if(a == e && b == d)
{
    Console.WriteLine("Число " + number + " является палиндромом");
}
else
{
    Console.WriteLine("Повторите программу");
}