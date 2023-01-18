/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] SetArraySpiral(int sizeRowCol, int startNum)
{
    int[,] arr = new int[sizeRowCol, sizeRowCol];
    int m = 0;
    int step = 0;
    while (step < sizeRowCol / 2)
    {
        //Заполнение верхней горизонтальной линии
        for (int i = 0; i < sizeRowCol - m; i++) 
        {
            arr[step, i + step] = startNum;
            startNum++;
        }
        //Заполнение правой вертикальной линии    
        for (int i = step + 1; i < sizeRowCol - step - 1; i++) //не заполняем крайний нижний элемент
        {
            arr[i, sizeRowCol - 1 - step] = startNum;
            startNum++;
        }
        //Заполнение нижней горизонтальной линии
        for (int i = sizeRowCol - 1 - step; i >= step + 1; i--) //не заполняем крайний левый элемент
        {
            arr[sizeRowCol - 1 - step, i] = startNum;
            startNum++;
        }
        //Заполнение левой вертикальной линии
        for (int i = sizeRowCol - (step + 1); i > step; i--) 
        {
            arr[i, step] = startNum;
            startNum++;
        }
        step++;
        m += 2;
    }

    if (sizeRowCol % 2 != 0)                           
    arr[sizeRowCol / 2, sizeRowCol / 2] = startNum; 
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
Console.WriteLine();
Console.WriteLine("СФОРМИРУЕМ МАССИВ:");
Console.Write(" -количество строк и столбцов = ");
int SizeArr = Convert.ToInt32(Console.ReadLine());
int[,] myArray = SetArraySpiral(SizeArr, 1);
Console.WriteLine();
PrintArray(myArray);
Console.WriteLine();

