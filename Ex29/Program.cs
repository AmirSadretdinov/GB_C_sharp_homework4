// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] array)
{   
    for (int i = 0; i < array.Length; i++)
    {   
        Console.WriteLine("Введите элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
Console.WriteLine("Введите размерность массива");
int x = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[x];
FillArray(mas);
PrintArray(mas);

