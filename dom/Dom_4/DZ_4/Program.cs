//Задача 25: Напишите цикл, который принимает на вход 
//два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Write numder1: ");
double A = Convert.ToUInt32(Console.ReadLine());

Console.WriteLine("Write natural numder2: ");
int B = Convert.ToInt32(Console.ReadLine());

double Power(double num1, int num2)
{
    double result = 1;
    for (int i = 0; i < num2; i++)
    {
result *= num1;
} 
return result;
}
double res = Power(A, B);
Console.WriteLine(res);