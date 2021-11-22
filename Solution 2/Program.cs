int numberA = new Random().Next(0,100);
Console.WriteLine(numberA);
int numberB = new Random().Next(0,100);
Console.WriteLine(numberB);

if(numberA > numberB)
{
    Console.Write("max=");
    Console.WriteLine(numberA);
    Console.Write("min=");
    Console.WriteLine(numberB);
}

else
{
    Console.Write("max=");
    Console.WriteLine(numberB);
    Console.Write("min=");
    Console.WriteLine(numberA);
}