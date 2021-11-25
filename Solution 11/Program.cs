int a = new Random().Next(10,99);
Console.Write("a = ");
Console.WriteLine(a);

int digit1 = a / 10;
Console.Write("digit1 = ");
Console.WriteLine(digit1);

int digit2 = a % 10;
Console.Write("digit2 = ");
Console.WriteLine(digit2);

if(digit1 > digit2)
{
    Console.Write("max = ");
    Console.WriteLine(digit1);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(digit2);
}