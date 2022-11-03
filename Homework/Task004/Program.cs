// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Hello! Please enter your name: ");
string name = Console.ReadLine();
Console.Write("Hello, ");
Console.WriteLine(name);
Console.Write(name);
Console.Write(", please enter number: ");
int number = Int32.Parse (Console.ReadLine());
Console.Write("I output all even numbers up to: ");
Console.WriteLine(number);
int N = 1;
int size = number;
while (N <= size)
{
    if (N % 2 == 0)
    {
        Console.WriteLine(N); 
        N = N + 1;
    }
    else
    {
        N = N + 1;
    }
}