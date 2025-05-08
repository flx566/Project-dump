int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a == b) Console.WriteLine("Равны");
else if (a > b) Console.WriteLine("Первое больше");
else Console.WriteLine("Первое меньше");

int a = Convert.ToInt32(Console.ReadLine());
if (a > 5 && a < 10) Console.WriteLine("Число больше 5 и меньше 10");
else Console.WriteLine("Неизвестное число");

int a = Convert.ToInt32(Console.ReadLine());
if (a == 5 || a == 10) Console.WriteLine("Число либо равно 5, либо равно 10");
else Console.WriteLine("Неизвестное число");

double sum = Convert.ToDouble(Console.ReadLine());
double percent = sum < 100 ? 0.05 : sum <= 200 ? 0.07 : 0.10;
sum += sum * percent;
Console.WriteLine(sum);

double sum = Convert.ToDouble(Console.ReadLine());
double percent = sum < 100 ? 0.05 : sum <= 200 ? 0.07 : 0.10;
sum += sum * percent + 15;
Console.WriteLine(sum);

Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
int op = Convert.ToInt32(Console.ReadLine());
switch (op)
{
    case 1: Console.WriteLine("Сложение"); break;
    case 2: Console.WriteLine("Вычитание"); break;
    case 3: Console.WriteLine("Умножение"); break;
    default: Console.WriteLine("Операция не определена"); break;
}

int op = Convert.ToInt32(Console.ReadLine());
double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());
switch (op)
{
    case 1: Console.WriteLine(x + y); break;
    case 2: Console.WriteLine(x - y); break;
    case 3: Console.WriteLine(x * y); break;
    default: Console.WriteLine("Операция не определена"); break;
}

