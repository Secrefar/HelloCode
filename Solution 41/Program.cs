Console.WriteLine ("Enter number A");
int A = int.Parse(Console.ReadLine ());

Console.WriteLine ("Enter number B");
int B = int.Parse(Console.ReadLine ());

Console.WriteLine ("Enter number C");
int C = int.Parse(Console.ReadLine ());

if ( A + B > C && A + C > B && B + C > A) Console.WriteLine ("Yes!");
else 
{ 
    Console.WriteLine("No!");
}