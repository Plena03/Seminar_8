//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Программа упорядочивает по убыванию элементы каждой строки двумерного массива.");
Console.WriteLine();

Console.Write("Введите число m: "); 
int m =  int.Parse(Console.ReadLine()); 
Console.WriteLine();

Console.Write("Введите число n: "); 
int n =  int.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите диапазон от 1 до: "); 
int r =  int.Parse(Console.ReadLine());
Console.WriteLine();


int[,] array = new int[m, n];
CreateArrayWithRandomNumbers(array);
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Упорядоченный массив: ");
Console.WriteLine();
NewArray(array);
PrintArray(array);
Console.WriteLine();

void NewArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

void CreateArrayWithRandomNumbers(int [,] array) {
    var random = new Random(); 

    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            array[i, j] = random.Next(r); 
        } 
    } 
} 

void PrintArray(int[,] array) {
    for (var i = 0; i < array.GetLength(0); i++) {
        for (var j = 0; j < array.GetLength(1); j++) 
        {
            Console.Write($"{array[i, j]}, ");
        }
        Console.WriteLine();
    }
}

