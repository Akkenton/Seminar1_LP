Console.Clear();
Console.WriteLine("Введите число периода: ");
int N = int.Parse(Console.ReadLine());
int otrN = -N;
Console.WriteLine(otrN);

if (N == 0)
{
    Console.WriteLine("Период равен 0");
}

if (N > 0)
{
    while (otrN <= N)
    {
        Console.Write(otrN + " ");
        otrN++;
    }
}

if (N < 0)
{
    while (N <= otrN)
    {
        Console.Write(N + " ");
        N++;
    }
}