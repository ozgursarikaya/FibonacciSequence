

Console.WriteLine("How many terms of the Fibonacci sequence would you like to see?");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Fibonacci Sequence:");
for (int i = 0; i < n; i++)
{
    Console.Write(Fibonacci(i) + " ");
}

static int Fibonacci(int n)
{
    if (n <= 1)
        return n;
    else
        return Fibonacci(n - 1) + Fibonacci(n - 2);
}
