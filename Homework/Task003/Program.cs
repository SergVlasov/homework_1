// Напишите программу, которая на вход принимает число и выдаёт,  является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Hello, please enter number: ");
int Number = Int32.Parse (Console.ReadLine());
string answer;
if(Number % 2 == 0)
{
   answer = ("YES, the number is even");
}
else
{
    answer = ("NO, the number is odd");
}
Console.WriteLine(answer);