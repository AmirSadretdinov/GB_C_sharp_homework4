// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int n)
{
    int res;
    if(n > 0) return res = n%10 + Sum(n/10);
    else return 0;
}
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int x = Sum(a);
Console.WriteLine($"Сумма цифр числа {a} = {x}");