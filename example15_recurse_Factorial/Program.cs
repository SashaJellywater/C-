
// int Factorial(int n)
// {
//     if (n==1) return 1;
//     else return n*Factorial(n-1);
// }
// // переполненние типа при запуске:
// for(int i =1;i<40;i++)
// {
// Console.WriteLine($"{i}! = {Factorial(i)}");
// }

double Factorial(int n) //меняем int на double
{
    if (n==1) return 1;
    else return n*Factorial(n-1);
}
// переполненние типа при запуске:
for(int i =1;i<40;i++)
{
Console.WriteLine($"{i}! = {Factorial(i)}");
}