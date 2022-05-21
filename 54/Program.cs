//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("Введите количество строк m: "); 
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m,n];

// Функция печати массива
void PrintArray(double[,] matr) 
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($" {matr[rows, columns]} ");   
        }
        Console.WriteLine();
    }
}
/*
void SelectionSort(double[,] matr)
{
	for (int rows = 0; rows < matr.GetLength(0); rows++)
	{
		int minPosition = rows;
		for (int columns = 0; columns < matr.GetLength(1); columns++)
		{
			if(array[rows, columns]<array[minPosition]) minPosition = rows;
		}
		double temporary = array[rows];
		array[rows] = array[minPosition];
		array[minPosition] = temporary;
	}
}
*/
void FillArray(double[,] matr) 
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[rows,columns] = new Random().Next(1,11); 
        }
        Console.WriteLine();
    }
}


FillArray(array);

PrintArray(array);

//SelectionSort(array);

PrintArray(array);

