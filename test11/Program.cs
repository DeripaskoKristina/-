Console.WriteLine("Введите первое число");
int x = int.Parse (Console.ReadLine());
Console.WriteLine("Введите второе число");
int y = int.Parse (Console.ReadLine());
if (x > y)
{
Console.WriteLine("Максимальное число" );
Console.WriteLine(x);
}
else
{
Console.WriteLine("Максимальное число", y);
Console.WriteLine(y);
}