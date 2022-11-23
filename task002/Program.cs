Console.Clear();
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (Math.Pow(number2, 2) == number1)
{
    Console.WriteLine("TRUE!");
}
else
{
    Console.WriteLine("FALSE!");
}