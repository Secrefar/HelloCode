int a = new Random().Next(0, 999000);
Console.Write("a = ");
Console.WriteLine(a);

a = a % 100;


if(a > 99)
{
     Console.Write("Third digit = ");
    Console.Write((a / 100) % 10);
}
   else
{
    Console.WriteLine("N/A");
}
