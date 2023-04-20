// Ввести два числа и определить не является ли второе квадратом первого

int a=int.Parse(Console.ReadLine());
int b=int.Parse(Console.ReadLine());
if (b*b == a)
   Console.WriteLine("ДА");   
else
{
  Console.WriteLine("НЕТ");   
}