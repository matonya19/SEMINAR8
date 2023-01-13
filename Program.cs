// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] array = new int[3, 4];
FillArrayRandom(array);
PrintArray(array);
Decrease(array);
Console.WriteLine();
PrintArray(array);


void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void Decrease(int[,] array)
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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine($"BИндекс строки с наименьшей суммой - {GetRowNumber(array)}");

int[,] GetArray(int m, int n, int min, int max)
    {
      int[,] result = new int[m, n];
      for (int i = 0; i < m; i++)
      {
        for (int j = 0; j < n; j++)
        {
          result[i, j] = new Random().Next(min, max +1);
        }
      }
      return result;
    }
    void PrintArray(int[,] array)
    {
      for (int i = 0; i < array.GetLength(0); i++)
      {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
      }
    }
    int GetRowNumber (int [,] array)
    {
      int row = 0;
      int minsum = 0;
      for (int i = 0; i < array.GetLength(1); i++)
      {
        minsum = minsum + array[0,i];
      }

      for (int i = 1; i < array.GetLength(0); i++)
      {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
          sum = sum + array[i,j];
        }
        if (minsum > sum)
        {
          minsum = sum;
          row = i;
        }
      }
      return row;
    }                      





// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.


int N = 4;
int[,] square = new int[N, N];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= square.GetLength(0) * square.GetLength(1))
{
  square[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < square.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= square.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > square.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintArray(square);

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}