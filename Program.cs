// Задача №25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
Console.Clear();

int DegreeAB(int a, int b)
{
    int result = a;
    int size = b-1;
    for(int count = 1; count <= size; count++)
    for(int count = 1; count <= (b-1); count++)
        result *= a;
    return result;
}
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int degreeAB = DegreeAB(a,b);
Console.WriteLine($"Число {a} в степени {b} = {degreeAB}");
Console.ReadLine();
*/

// Задача №27.  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
Console.Clear();
int SumDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    return sum;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sumDigits = SumDigits(num);
Console.WriteLine($"Сумма цифр в числе {num} = {sumDigits}");
Console.ReadLine();
*/

// Задача №29. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
Console.Clear();
int[] CreateArray(int size)
{
    while(size < 0)
    {
        Console.Write("Размер массива не может быть отрицательным числом! Введите положительное число: ");
        size = Convert.ToInt32(Console.ReadLine());
    }
    int[] array = new int[size];
    if(size == 0) 
        Console.WriteLine("Размер массива = 0, массив пустой.");
    else
    {
        for(int i = 0; i < size; i++)
        {
            Console.Write("Введите элемент массива: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return array; 
}
void PrintArray(int [] newArray)
{
    for(int i = 0; i < newArray.Length; i++)
        Console.Write(newArray[i] + " ");
    Console.WriteLine();
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] YourArray = CreateArray(size);
Console.ForegroundColor = ConsoleColor.Green;
PrintArray(YourArray);
Console.ReadLine();
*/