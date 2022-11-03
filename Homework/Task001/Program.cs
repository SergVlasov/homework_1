// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Hello, please enter two numbers:");
int numberA = Int32.Parse(Console.ReadLine());
int numberB = Int32.Parse(Console.ReadLine());
int max=0, min = 0;
if (numberA>numberB)
{
    max = numberA; 
    min = numberB;
}
else
{
    max = numberB; 
    min = numberA;
}
Console.WriteLine($"Num {max} is maximum");
Console.WriteLine($"Num {min} is minimum");