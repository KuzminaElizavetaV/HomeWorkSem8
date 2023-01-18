/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] SetMatrix(int row, int col, int beginNum, int endNum)
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(beginNum, endNum + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
//функция находит произведение элементов строки одной матрицы на столбец другой матрицы (по индексам)
int MultiplyRowByColumn(int[,] firstArr, int[,] secondArr, int indexRowFirst, int indexColSecond)
{
    int result = 0;
    for (int i = 0; i < firstArr.GetLength(1); i++)
        result += firstArr[indexRowFirst, i] * secondArr[i, indexColSecond];
    return result;
}

int[,] MatrixMultiplication(int[,] firstArr, int[,] secondArr)
{
    int[,] resultArray = new int[firstArr.GetLength(0), secondArr.GetLength(1)];
    for (int i = 0; i < firstArr.GetLength(0); i++)
    {
        for (int j = 0; j < secondArr.GetLength(1); j++)
        {
            resultArray[i, j] = MultiplyRowByColumn(firstArr, secondArr, i, j);
        }
    }
    return resultArray;
}
Console.WriteLine();
Console.WriteLine("СФОРМИРУЕМ ПЕРВУЮ МАТРИЦУ:");
Console.Write(" -количество строк = ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.Write(" -количество столбцов = ");
int col1 = Convert.ToInt32(Console.ReadLine());
int[,] firstMatrix = SetMatrix(row1, col1, 0, 10);
PrintArray(firstMatrix);

Console.WriteLine();
Console.WriteLine("СФОРМИРУЕМ ВТОРУЮ МАТРИЦУ:");
Console.Write(" -количество строк = ");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.Write(" -количество столбцов = ");
int col2 = Convert.ToInt32(Console.ReadLine());
int[,] secondMatrix = SetMatrix(row2, col2, 0, 10);
PrintArray(secondMatrix);
Console.WriteLine();
if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
{
    Console.WriteLine("Произведение двух матриц: ");
    PrintArray(MatrixMultiplication(firstMatrix, secondMatrix));
}
else
    Console.WriteLine("Умножение матриц невозможно, так как они не согласованы");
