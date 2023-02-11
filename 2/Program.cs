int a = 8;
int b = 8;
int max = a;
int min = b;

if (max == min) Console.WriteLine("Числа равны");

if (max > min)
{
    Console.Write("max = ");
    Console.Write(max);
    Console.WriteLine();
    Console.Write("min = ");
    Console.Write(min);
}

if (max < min)
{
    Console.Write("max=");
    Console.Write(min);
    Console.WriteLine();
    Console.Write("min=");
    Console.Write(max);
}