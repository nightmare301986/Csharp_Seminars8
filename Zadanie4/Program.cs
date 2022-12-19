/* Задача 4. (*) Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int Promt(String message) //Приглашение ко вводу
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Promt("Введите размерность квадратной матрицы (количество строк равно количеству столбцов)  ");
int n = m;
int[,] matr = CreateMatrixSpiral(m, n);

int[,] CreateMatrixSpiral(int n, int m) //Построение спиральной квадратной матрицы
{
    var matr = CreateArraySpiral(n, m);
    for (int j = 0; j < m; j++)
    {
        for (int i = 0; i < n / 2; i++)
        {
            var tmp = matr[i, j];
            matr[i, j] = matr[i, m - j - 1];
            matr[i, m - j - 1] = tmp;
        }
    }
    return matr;
}

int[,] CreateArraySpiral(int m, int n) //Создание массива для спиральной матрицы
{
    int[,] matr = new int[m, n];
    int rows = 0, cols = 0, movex = 1, movey = 0, pathChanges = 0, ost = n;

    for (int i = 0; i < matr.Length; i++)
    {
        matr[cols, rows] = i + 1;
        if (--ost == 0)
        {
            ost = n * (pathChanges % 2) + m * ((pathChanges + 1) % 2) - (pathChanges / 2 - 1) - 2;
            int temp = movex;
            movex = -movey;
            movey = temp;
            pathChanges++;
        }
        rows += movex;
        cols += movey;
    }
    return matr;
}
void PrintMatrix(int[,] matr1)//Вывод матрицы на экран
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

PrintMatrix(matr);