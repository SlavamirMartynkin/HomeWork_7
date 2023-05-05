//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет


int ReadInt(string argument) // проверка на число
{
    Console.Write(argument);
    int i;
    while (!int.TryParse(Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Это не число!");
        Console.Write(argument);
    }
    return i;
}

int[,] FillFrrayMatrix(int[,] matr) // заполняет матрицу случайными числами
{
    Random rnd =new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = rnd.Next(0, 10);
        }
    }
    return matr;
}

void PrintArrayMatrix(int[,] matr)  // выводит матрицу на экран
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void Proverka(int[,] matr, int i, int j)
{
    i--;//чтобы позиции начинались с 1 , а не с 0
    j--;
    if (i < matr.GetLength(0) && j < matr.GetLength(1))
    {
        System.Console.WriteLine(matr[i,j]);
    }
    else
    {
        System.Console.WriteLine("Такой позиции нет");
    }
}



int[,] matrix = new int[5, 5];
matrix = FillFrrayMatrix(matrix);
PrintArrayMatrix(matrix);
int i = ReadInt("Введите позицию по горизонтали ");
int j = ReadInt("Введите позицию по вертикали ");
Proverka(matrix, i, j);

