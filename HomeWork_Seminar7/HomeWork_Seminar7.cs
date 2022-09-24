//  Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5  7    -2   -0,2
// 1   -3,3   8   -9,9
// 8    7,8  -7,1  9
//////////////////////////////////////////////////////////////////////////////////////////////////

// int[] InputArrayParametr(string text)
// {
//     int[] dataArray = new int[4];
//     System.Console.WriteLine(text);
//     System.Console.WriteLine("Введите количество строк массива");
//     dataArray[0] = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Введите количество столбцов массива");
//     dataArray[1] = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Введите 1 значение интервала генерации");
//     dataArray[2] = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Введите 2 значение интервала генерации");
//     dataArray[3] = Convert.ToInt32(Console.ReadLine());
//     return dataArray;
// }


// double[,] GenerateDoubArray(int[] inputDataArr)
// {
//     double[,] genarray = new double[inputDataArr[0], inputDataArr[1]];
//     var rand = new Random();
//     for (int i = 0; i < inputDataArr[0]; i++)
//     {
//         for (int j = 0; j < inputDataArr[1]; j++)
//         {
//             genarray[i, j] = rand.NextDouble() * (inputDataArr[3] + 1 - inputDataArr[2]) + inputDataArr[2];
//         }
//     }
//     return genarray;
// }

// void PrintArray(double[,] printarray)
// {
//     for (int i = 0; i < printarray.GetLength(0); i++)
//     {
//         for (int j = 0; j < printarray.GetLength(1); j++)
//         {
//             System.Console.Write($"{printarray[i, j]:f1}\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[] valueArray = InputArrayParametr("Введите данные массива");
// var doublearray = GenerateDoubArray(valueArray);

// PrintArray(doublearray);

// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет


// int[] InputArrayParametr(string text)
// {
//     int[] dataArray = new int[2];
//     System.Console.WriteLine(text);
//     System.Console.WriteLine("Введите количество строк массива");
//     dataArray[0] = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Введите количество столбцов массива");
//     dataArray[1] = Convert.ToInt32(Console.ReadLine());
//     return dataArray;
// }


// double[,] GenerateDoubArray(int[] inputDataArr)
// {
//     double[,] genarray = new double[inputDataArr[0], inputDataArr[1]];
//     var rand = new Random();
//     for (int i = 0; i < inputDataArr[0]; i++)
//     {
//         for (int j = 0; j < inputDataArr[1]; j++)
//         {
//             genarray[i, j] = rand.NextDouble() * 10;
//         }
//     }
//     return genarray;
// }

// void PrintArray(double[,] printarray)
// {
//     for (int i = 0; i < printarray.GetLength(0); i++)
//     {
//         for (int j = 0; j < printarray.GetLength(1); j++)
//         {
//             System.Console.Write($"{printarray[i, j]:f1}\t");
//         }
//         System.Console.WriteLine();
//     }
// }


// (int, int) InputIndexCoordinate(string text)
// {
//     System.Console.WriteLine(text);
//     System.Console.WriteLine("Введите номер строки");
//     int inputrow = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Введите номер столбца");
//     int inputcolumn = Convert.ToInt32(Console.ReadLine());
//     return (inputrow, inputcolumn);
// }



// (bool, double) GetResultIndex(int inputrow, int inputcolumn, double[,] getIndexArray)
// {
//     double findindexnumb = 0;
//     bool flag = false;
//     int rowlength = getIndexArray.GetLength(0);
//     int columnlength = getIndexArray.GetLength(1);
//     if (inputrow <= rowlength && inputrow >= 1 && inputcolumn <= columnlength && inputcolumn >= 1)
//     {
//         findindexnumb = getIndexArray[inputrow - 1, inputcolumn - 1];
//         flag = true;
//         return (flag, findindexnumb);
//     }
//     else return (flag, findindexnumb);
// }

// void PrintResultIndex(bool resultflag, double findindexnumb)
// {
//     System.Console.WriteLine("Результаты значения поиска значения по индексу ");
//     if (resultflag == true)
//     {
//         System.Console.WriteLine($"Результат поиска по индексу => {findindexnumb:f1}");
//     }
//     else
//     {
//         System.Console.WriteLine("Параметр индекса выходит за границы массива, значение отсутствует");

//     }
// }


// int[] valueArray = InputArrayParametr("Введите данные массива");

// var doublearray = GenerateDoubArray(valueArray);

// PrintArray(doublearray);

// (int rowind, int columnind) = InputIndexCoordinate("Введите значения для поиска значения по индексам");

// (bool flag, double getresultindex) = GetResultIndex(rowind, columnind, doublearray);

// PrintResultIndex(flag, getresultindex);




// Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// int[] InputArrayParametr(string text)
// {
//     int[] dataArray = new int[2];
//     System.Console.WriteLine(text);
//     System.Console.WriteLine("Введите количество строк массива");
//     dataArray[0] = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Введите количество столбцов массива");
//     dataArray[1] = Convert.ToInt32(Console.ReadLine());
//     return dataArray;
// }


// int[,] GenerateArray(int[] inputarr)
// {
//     int[,] arr = new int[inputarr[0], inputarr[1]];
//     var random = new Random();

//     for (int i = 0; i < inputarr[0]; i++)
//     {
//         for (int j = 0; j < inputarr[1]; j++)
//         {
//             arr[i, j] = random.Next(0, 20);
//         }
//     }
//     return arr;
// }

// void PrintArray(int[,] printarr)
// {
//     int row = printarr.GetLength(0);
//     int columns = printarr.GetLength(1);
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             System.Console.Write($"{printarr[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// double[] AverageColumns(int[,]inputarrays)
// {
//     int row = inputarrays.GetLength(0);
//     int column = inputarrays.GetLength(1);
//     // var columnsum = 0;
//     double[] outarrays = new double[column];
//     for (int i = 0; i < column; i++)
//     {
//         for (int j = 0; j < row; j++)
//         {
//             outarrays[i]+=inputarrays[j, i]; 
//         }
//         outarrays[i]/=column;
//     } 
//     return outarrays;
// }
// void AveragePrint(double[] inputAverArr)
// {
//     System.Console.WriteLine();
//     for (int i = 0; i < inputAverArr.Length; i++)
//     {
//         System.Console.Write($"{Math.Round(inputAverArr[i],2)}\t");
//     }
// }
// int[] inputValue = InputArrayParametr("Введите данные для формирования массива");
// int[,] doublearray = GenerateArray(inputValue);
// PrintArray(doublearray);
// AveragePrint(AverageColumns(doublearray));