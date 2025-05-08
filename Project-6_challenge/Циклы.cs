decimal sum = Convert.ToDecimal(Console.ReadLine());
int months = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < months; i++)
{
    sum += sum * 0.07m;
}
Console.WriteLine(sum);

decimal sum = Convert.ToDecimal(Console.ReadLine());
int months = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (i < months)
{
    sum += sum * 0.07m;
    i++;
}
Console.WriteLine(sum);

for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.Write(i * j + " ");
    }
    Console.WriteLine();
}

while (true)
{
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    if (a >= 0 && a <= 10 && b >= 0 && b <= 10)
    {
        Console.WriteLine(a * b);
        break;
    }
    else
    {
        Console.WriteLine("Введенные числа недопустимы");
    }
}

