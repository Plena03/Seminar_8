// Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
// 	Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Программа находит произведение двух матриц.");
Console.WriteLine();

Console.Write("Введите число строк у матрицы № 1: "); 
int m =  int.Parse(Console.ReadLine()); 
Console.WriteLine();

Console.Write("Введите число столбцов у матрицы № 1: "); 
int n =  int.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите число столбцов у матрицы № 2: "); 
int p =  int.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите диапазон от 1 до: "); 
int r =  int.Parse(Console.ReadLine());
Console.WriteLine();

	
int[,] first = new int[m, n];
CreateArrayWithRandomNumbers(first);
Console.WriteLine("Матрица № 1:");
PrintArray(first);
	
int[,] secomd = new int[n, p];
CreateArrayWithRandomNumbers(secomd);
Console.WriteLine("Матрица № 2:");
PrintArray(secomd);

int[,] result = new int[m,p];

MatrixProduct(first, secomd, result);
Console.WriteLine("Произведение матриц № 1 и № 2 равно ");
PrintArray(result);

void MatrixProduct(int[,] first, int[,] secomd, int[,] result)
{
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < first.GetLength(1); k++)
      {
        sum += first[i,k] * secomd[k,j];
      }
      result[i,j] = sum;
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
