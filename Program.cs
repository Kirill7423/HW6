// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
/*

int [] CreateNewArray ()
{
    Console.WriteLine("Введите количество элементов последовательности: ");
    int size_array = Convert.ToInt32(Console.ReadLine());
    int [] randomArray = new int[size_array];    
    for (int i = 0; i < size_array; i++)
    {
        Console.WriteLine("Введите число: ");
        randomArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return randomArray;
}

void PrintArray (int [] array_to_print)
{
    Console.Write("Ваша последовательность чисел -> ");
    for (int i = 0; i < array_to_print.Length; i++)
        Console.Write (array_to_print[i] + ", ");
    Console.WriteLine("\b\b");
}

void checkPosit (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count += 1;
    }
    Console.WriteLine($"Вы вввели {count} положительных числа");
}

int [] massiv = CreateNewArray();
PrintArray(massiv);
checkPosit(massiv);
*/



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
double [] crospoint ( double b1, double k1, double b2, double k2)
{
        double koordX = 1;
        double koordY = 0;
        double [] point = new double [2];
        koordX = Math.Round(((b2 - b1) / (k1 - k2)),2);
        koordY = Math.Round((k1 * koordX + b1), 2); 
        point[0] = koordX;
        point[1] = koordY;
    return point;
}

Console.WriteLine("Введите b1 ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k1 ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b2: ");
int num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k2: ");
int num4 = Convert.ToInt32(Console.ReadLine());

double [] massiv = crospoint (num1, num2, num3, num4);
Console.WriteLine($"Точка пересечений ({massiv[0]}; {massiv[1]})");
*/