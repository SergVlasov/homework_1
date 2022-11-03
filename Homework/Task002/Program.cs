// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Hello, please enter three numbers:");
int numberA = Int32.Parse(Console.ReadLine());
int numberB = Int32.Parse(Console.ReadLine());
int numberC = Int32.Parse(Console.ReadLine());
int  max = numberA;
if(numberB > max)
{
    max = numberB;
}
if(numberC > max)
{
    max = numberC;
}
Console.WriteLine($"Num {max} is maximum ");