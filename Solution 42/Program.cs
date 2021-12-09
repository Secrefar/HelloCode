Console.WriteLine ("Enter a number");
Int64 A = Int64.Parse (Console.ReadLine ());

int count = 0;

while (A > 0)
{
    A = A/10;
    count++;
    char [] array = A.ToCharArray();
}

