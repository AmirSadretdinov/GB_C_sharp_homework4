// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Stepen(int A, int B)
{   int result = 1;
    if (B>0) return result = A * Stepen(A, B-1);
    return 1;
}
System.Console.WriteLine("Введите А");
int inputA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите В");
int inputB = Convert.ToInt32(Console.ReadLine());
double result = Stepen(inputA,inputB);
System.Console.WriteLine($"{inputA}^{inputB} = {result}");