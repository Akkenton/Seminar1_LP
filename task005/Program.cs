Console.Clear();
Console.Write("Enter: ");
int num = int.Parse(Console.ReadLine());
int lastN;
if (num > -100 && num < 100)
{
    Console.WriteLine($"Число {num} меньше трехзначного!");
}
else
{
    lastN = num % 10;
    Console.WriteLine($"Последняя цифра из числа {num} является {lastN}");
}