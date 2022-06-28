// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите два числа");
int num1=Convert.ToInt32(Console.ReadLine());
int num2=Convert.ToInt32(Console.ReadLine());
if (num1<num2)
  {
    int max=num2;
    int min=num1;
    Console.WriteLine(max+" - большее число");
    Console.WriteLine(min+" - меньшее число");
  }
else
  {
    int max=num1;
    int min=num2;
    Console.WriteLine(max+" - большее число");
    Console.WriteLine(min+" - меньшее число");
  }