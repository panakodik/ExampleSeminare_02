// Дано число. Проверить кратно ли оно 7 и 23
Console.Clear();
Console.Clear();
int number = new Random().Next(1,1000);
Console.WriteLine("Дано число " + number);
if(number % 7 == 0)
{
    Console.WriteLine("Число " + number + " кратно 7");
}   
else 
{
    Console.WriteLine("Число " + number + " не кратно 7"); 
}
if(number % 23 == 0)
{
    Console.WriteLine("Число " + number + " кратно 23");
}
else
{
    Console.WriteLine("Число " + number + " не кратно 23"); 
}