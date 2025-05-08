string fio = Console.ReadLine();
int age = Convert.ToInt32(Console.ReadLine());
double height = Convert.ToDouble(Console.ReadLine());
double weight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(fio + " " + age + " " + height + " " + weight);
Console.WriteLine($"{fio}, {age}, {height}, {weight}");
Console.WriteLine(string.Join(", ", fio, age, height, weight));

