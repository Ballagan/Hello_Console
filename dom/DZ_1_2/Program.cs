//Задача 4: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22





Console.WriteLine("Ввдите число");
Console.WriteLine(" a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" b =");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" c =");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b)
{
    if (b < c)
    {
        Console.WriteLine("max c=" + c);
    }
else
{
    Console.WriteLine("max b=" + b);
}
}
    else
if (a > c)
{
    Console.WriteLine("max a=" + a);
}
else
{
    Console.WriteLine("max c= " + c);
}