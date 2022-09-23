// Задайте  двухмерный массив заполненный случайными целыми числами.

// (int, int) ArraySizeInput(int rows, int columns)
// {
//     System.Console.WriteLine("Введите количество строк массива");
//     rows = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Введите количество столбцов массива");
//     columns = Convert.ToInt32(Console.ReadLine());

//     return (rows, columns);
// }

// int[,] GenerateArray(int rowsSize, int columnsSize)
// {
//     int[,] arr = new int[rowsSize, columnsSize];
//     var random = new Random();
//     for (int i = 0; i < rowsSize; i++)
//     {
//         for (int j = 0; j < columnsSize; j++)
//         {
//             arr[i, j] = random.Next(-50, 50);
//         }
//     }

//     return arr;
// }
// void PrintArray(int[,] array)
// {
//     int rowslength = array.GetLength(0);
//     int columnslength = array.GetLength(1);
//     for (int i = 0; i < rowslength; i++)
//     {
//         for (int j = 0; j < columnslength; j++)
//         {
//             System.Console.Write($"{array[i,j]}\t");
//         }
//         System.Console.WriteLine();
//     }

// }
// int row = 0;
// int column  = 0;
//  (int rows,  int columns) = ArraySizeInput(row, column);
// int [,]arrays = GenerateArray(rows, columns);
// PrintArray(arrays);


// Задайте двумерный массив размера m на n, каждый элемент 
// в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


// int[] ArraySizeInput(string text)
// {
//     System.Console.WriteLine(text);
//     int[] newwalue = new int[4];
//     System.Console.WriteLine("Введите количество строк массива");
//     newwalue[0] = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Введите количество столбцов массива");
//     newwalue[1] = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Минимальное генерируемое число");
//     newwalue[2] = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Максимальное генерируемое число");
//     newwalue[3] = Convert.ToInt32(Console.ReadLine());
//     return newwalue;
// }

// // int[,] ArraySumIndex(int[] arr) //Задача 2
// // {
// //     int[,] array = new int[arr[0], arr[1]];

// //     for (int i = 0; i < arr[0]; i++)
// //     {
// //         for (int j = 0; j < arr[1]; j++)
// //         {
// //             array[i, j] = i + j;
// //         }

// //     }

// //     return array;
// // }

// int[,] GenerateArray(int[] arr)
// {
//     int[,] array = new int[arr[0], arr[1]];

//     var random = new Random();

//     for (int i = 0; i < arr[0]; i++)
//     {
//         for (int j = 0; j < arr[1]; j++)
//         {
//             array[i, j] = random.Next(arr[2], arr[3]);
//         }
//         System.Console.WriteLine();
//     }

//     return array;

// }

// int[,] FindEvenIndex(int[,] arr)
// {
//     int rowslength = arr.GetLength(0);
//     int columnslength = arr.GetLength(1);

//     for (int i = 0; i < rowslength; i++)
//     {
//         for (int j = 0; j < columnslength; j++)
//         {
//             if (i % 2 == 1 & j % 2 == 1)
//             {
//                 arr[i, j] *= arr[i, j];
//             }

//         }
//     }
//     return arr;
// }


// void PrintArray(int[,] arrays)
// {
//     var rowlength = arrays.GetLength(0);
//     var columnlength = arrays.GetLength(1);

//     for (int i = 0; i < rowlength; i++)
//     {
//         for (int j = 0; j < columnlength; j++)
//         {
//             System.Console.Write($"{arrays[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
// }



// // Переменные для решения задачи 2
// int[] sizearray = ArraySizeInput("Введите параметры для задания массива");
// // var matrix = ArraySumIndex(sizearray);
// // PrintArray(matrix);

// /////////////////////////////////////////////////////////////////
// // Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные, 
// // и замените эти элементы на их квадраты

// int[,] matrix1 = GenerateArray(sizearray);

// PrintArray(matrix1);

// System.Console.WriteLine();

// PrintArray(FindEvenIndex(matrix1));



int[] ArrayInputValidation(string text)
{
    System.Console.WriteLine(text);
    int[] valuearr = new int[4];
    System.Console.WriteLine("Введите количество строк массива");
    valuearr[0] = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите количество столбцов массива");
    valuearr[1] = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите нижнюю границу интервала");
    valuearr[2] = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите верхнюю границу интервала");
    valuearr[3] = Convert.ToInt32(Console.ReadLine());
    if (valuearr[0] != valuearr[1])
    {
        return ArrayInputValidation("Количество строк должно быть равно колличеству столбцов.");
    }
    else return valuearr;
}

int ArrayFindInputNumb(string text)
{
    System.Console.WriteLine(text);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}


int[,] GenerateArray(int[] input)
{
    int[,] array = new int[input[0], input[1]];
    var random = new Random();
    for (int i = 0; i < input[0]; i++)
    {
        for (int j = 0; j < input[1]; j++)
        {
            array[i, j] = random.Next(input[2], input[3] + 1);
        }
    }
    return array;
}

void PrintArray(int[,] printar)
{
    int rows = printar.GetLength(0);
    int columns = printar.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            System.Console.Write($"{printar[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[] DiagonalSum(int[,] arrays)
{
    int rows = arrays.GetLength(0);
    int columns = arrays.GetLength(1);
    int sum = 0;
    int[] sumarr = new int[rows + 1];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == j)
            {
                sum += arrays[i, j];
                sumarr[i] = arrays[i, j];

            }
        }
    }
    sumarr[rows] = sum;

    return sumarr;
}

void PrintSummArray(int[] inputarr)
{
    int lenght = inputarr.Length;
    System.Console.Write($"[ {inputarr[0]} ");
    for (int i = 1; i < lenght - 1; i++)
    {
        System.Console.Write($"+ {inputarr[i]} ");
    }
    System.Console.Write($"] = {inputarr[lenght - 1]}");
}

void FindNumbPos(int[,] findarr, int searchnumb)
{
    int rows = findarr.GetLength(0);
    int columns = findarr.GetLength(1);
    bool flag = false;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (findarr[i, j] == searchnumb)
            {
                flag = true;
                System.Console.WriteLine($"Найдено число - {searchnumb}, позиция => [ {i + 1}, {j + 1} ]");
                
                break;
            }
        }
    }
    if (flag == false)
    {
        System.Console.WriteLine($"Число - {searchnumb} => не найдено!");
    }
}

var arr = ArrayInputValidation("Введите данные массива");
var matrix = GenerateArray(arr);
PrintArray(matrix);
// var sumar = DiagonalSum(matrix);
// PrintSummArray(sumar);
var findnumb = ArrayFindInputNumb("Введите число для поиска");
FindNumbPos(matrix, findnumb);

