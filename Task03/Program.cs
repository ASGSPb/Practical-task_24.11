// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.WriteLine($"Введите из чисел с каким колличеством знаков N  должен состоять массив.");
Console.Write("N = ");
int n = Convert.ToInt32(Console.ReadLine());

int digitUp = 1;   
for (int i = 0; i <= n-1; i++)
{
    digitUp = digitUp * 10;           
}


Console.WriteLine($"Матрица будет состоять из цифр диапозона int Random({-1 * (digitUp -1)}, {digitUp}) ");


int [] FillingArray(int size)
{
    int [] array1 = new int [size];
    for (int i = 0; i < 8; i++)
    {
        array1[i] = new Random().Next((-1 * (digitUp -1)), digitUp);
    }
    return array1;
}
int [] array = FillingArray(8);
Console.Write(String.Join(", ", array));

