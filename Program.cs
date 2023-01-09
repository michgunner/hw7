//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int[,] CreateRandom2DArray()
{
   Console.Write("Please, enter number of rows: ");
   int rows = Convert.ToInt32(Console.ReadLine());
   Console.Write("Please, enter number of columns: ");
   int columns = Convert.ToInt32(Console.ReadLine());

   Console.Write("Please, enter min value in array: ");
   int minValue = Convert.ToInt32(Console.ReadLine());
   Console.Write("Please, enter max value in array: ");
   int maxValue = Convert.ToInt32(Console.ReadLine());

   int[,] array = new int[rows, columns];

   for (int i = 0; i < rows; i++)
      for (int j = 0; j < columns; j++)
         array[i, j] = new Random().Next(minValue, maxValue+1);
   
   return array;
}

void Show2DArray(int[,] array)
{
   for(int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j<array.GetLength(1); j++)
         Console.Write(array[i,j] + " ");
      Console.WriteLine();
   }
   Console.WriteLine();
}

int[,] array = CreateRandom2DArray();
Show2DArray(array); 




//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void CheckValue(int[,] array, int row, int column)
{
   try
   {
      Console.WriteLine("In this cell lies value of - " + array[row, column]);
   }catch(Exception)
   {
      Console.WriteLine("Your index is out of bounds!");
   }
}

   Console.Write("Please, enter row index with interested number: ");
   int row = Convert.ToInt32(Console.ReadLine());
   Console.Write("Please, enter column index with interested number: ");
   int column = Convert.ToInt32(Console.ReadLine());

   CheckValue(array, row, column);





//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

double[] AverageOfArrayRow(int[,] array)
{
   double[] allAverages = new double[array.GetLength(0)];
   int index = 0;

   for (int i = 0; i < array.GetLength(0); i++)
   {
      double average = 0;
      for(int j = 0; j < array.GetLength(1); j++)
         average += array[i,j];
      allAverages[index] = Math.Round(average/array.GetLength(1), 3);
      index++;
   }
   return allAverages;
}

void ShowDoubleArray(double[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write(array[i]);
      if(i == array.Length-1) Console.Write(".");
      else Console.Write("; ");
   }
}

double[] arrayOfAverages = AverageOfArrayRow(array);
ShowDoubleArray(arrayOfAverages);
