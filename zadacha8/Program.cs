// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("введите число");
int Num = Convert.ToInt32(Console.ReadLine());
for (int count=2; count<Num+1; count++)
  {
  if (count%2==0)
    {
        Console.WriteLine(count);
    }
  }