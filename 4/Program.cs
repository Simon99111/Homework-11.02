int a = 85;
int b = 12;
int c = 67;
int max =0;
if (a >= b && a >= c) max = a;
if (b >= a && b >= c) max = b;
if (c >= a && c >= b) max = c;
Console.WriteLine(max);