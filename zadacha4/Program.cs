// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("введите три числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1>num2 && num1>num3)
{
    int max=num1;
    Console.WriteLine(max+" - наибольшее число");
}
else if (num2>num1 && num2>num3)
{
    int max=num2;
    Console.WriteLine(max+" - наибольшее число");
}
else if (num3>num2 && num3>num1)
{
    int max=num3;
    Console.WriteLine(max+" - наибольшее число");
}