// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int num = Math.Abs ( a );
int sum = 0;

while ( num > 0)
{
    sum = num % 10 + sum;
    num = num / 10;   
}
Console.WriteLine($"Сумма цифр в числе {a} равна {sum}");


