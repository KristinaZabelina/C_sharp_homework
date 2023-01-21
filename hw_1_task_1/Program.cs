// Напишите программу, 
// которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = b;
if (b > max)
{
  max = b;
  min = a;
}

Console.Write(max);
Console.WriteLine(" - большее");
Console.Write(min);
Console.WriteLine(" - меньшее");