Console.Clear();
Console.WriteLine("Введите число а ");
int a = int.Parse(Console.ReadLine ());
Console.WriteLine("Введите число b ");
int b = int.Parse(Console.ReadLine ());

if (b>a) 
{
    Console.Write ("Максимальное число =");
    Console.WriteLine (b);
} 
else
{
    Console.Write ("Максимальное число =");
    Console.WriteLine (a);
}