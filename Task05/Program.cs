//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());
if(number>=100&&number<1000)
{
    Console.Write("Последняя цыфра числа: " + number%10);
}
else 
{
    Console.Write("Это число не трехзначное!");
}

