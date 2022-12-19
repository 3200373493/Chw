Console.Clear();
Console.Write("Введите три числа. Первое число= ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число= ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число= ");
int c = int.Parse(Console.ReadLine());

if (a>b && a>c) 
{
Console.WriteLine($"Максимальное число ={a}");
} 
else if(b>a && b>c)
{
Console.WriteLine($"Максимальное число ={b}");
}
else 
{
Console.WriteLine($"Максимальное число ={c}");
}